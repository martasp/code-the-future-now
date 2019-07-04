namespace CodeTheFutureNow
{
    using System.Linq;
    using System.Threading.Tasks;
    using NServiceBus.Testing;
    using Xunit;

    public class DiscountingTests
    {
        [Fact]
        public async Task TenPercentDiscount()
        {
            var discounting = new Discounting { Data = new Discounting.DiscountingData() };

            var order1 = new SubmitOrder { Total = 60 };
            var order2 = new SubmitOrder { Total = 60 };
            var order3 = new SubmitOrder { Total = 10 };
            var order4 = new SubmitOrder { Total = 20 };

            var context = new TestableMessageHandlerContext();

            // week total 0
            await discounting.Handle(order1, context);
            Assert.Equal(0, context.SentMessages.Select(m => m.Message).OfType<ProcessOrder>().Last().Discount);

            // week total 60
            await discounting.Handle(order2, context);
            Assert.Equal(0, context.SentMessages.Select(m => m.Message).OfType<ProcessOrder>().Last().Discount);

            // week total 120
            await discounting.Handle(order3, context);
            Assert.Equal(10, context.SentMessages.Select(m => m.Message).OfType<ProcessOrder>().Last().Discount);

            // week total 130
            // 1 week since order 1!!!
            await discounting.Timeout(order1, context);

            // week total 70
            await discounting.Handle(order4, context);
            Assert.Equal(0, context.SentMessages.Select(m => m.Message).OfType<ProcessOrder>().Last().Discount);
        }
    }
}

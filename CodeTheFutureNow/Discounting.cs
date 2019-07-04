namespace CodeTheFutureNow
{
    using System;
    using System.Threading.Tasks;
    using NServiceBus;

    public class SubmitOrder
    {
        public Guid CustomerId { get; set; }
        public double Total { get; set; }
        // more properties
    }

    public class ProcessOrder
    {
        public int Discount { get; set; }
        // more properties
    }

    public class Discounting
        // : Saga<Discounting.DiscountingData>,
        // IAmStartedByMessages<SubmitOrder>,
        // IHandleTimeouts<SubmitOrder>
    {
        // public async Task Handle(SubmitOrder message, IMessageHandlerContext context)
        // {
        //     var discount = Data.WeekTotal >= 100 ? 10 : 0;

        //     await context.Send(new ProcessOrder { Discount = discount });

        //     Data.WeekTotal += message.Total;

        //     await RequestTimeout(context, TimeSpan.FromDays(7), message);
        // }

        // public Task Timeout(SubmitOrder state, IMessageHandlerContext context)
        // {
        //     Data.WeekTotal -= state.Total;
        //     return Task.CompletedTask;
        // }

        // protected override void ConfigureHowToFindSaga(SagaPropertyMapper<DiscountingData> mapper) =>
        //     mapper.ConfigureMapping<SubmitOrder>(m => m.CustomerId).ToSaga(s => s.CustomerId);

        // public class DiscountingData : ContainSagaData
        // {
        //     public Guid CustomerId { get; set; }
        //     public double WeekTotal { get; set; }
        // }
    }
}

namespace CodeTheFutureNow
{
    using System;
    using System.Threading.Tasks;
    using NServiceBus;

    public class FlightBooked
    {
        public Guid HolidayId { get; set; }
    }

    public class HotelBooked
    {
        public Guid HolidayId { get; set; }
    }

    public class CarBooked
    {
        public Guid HolidayId { get; set; }
    }

    public class HolidayBooked
    {
        public Guid HolidayId { get; set; }
    }

    public class HolidayBooking
        // : Saga<HolidayBooking.HolidayBookingData>,
        // IAmStartedByMessages<FlightBooked>,
        // IAmStartedByMessages<HotelBooked>,
        // IAmStartedByMessages<CarBooked>
    {
        // public Task Handle(FlightBooked message, IMessageHandlerContext context)
        // {
        //     Data.IsFlightBooked = true;
        //     return CheckBooked(context);
        // }

        // public Task Handle(HotelBooked message, IMessageHandlerContext context)
        // {
        //     Data.IsHotelBooked = true;
        //     return CheckBooked(context);
        // }

        // public Task Handle(CarBooked message, IMessageHandlerContext context)
        // {
        //     Data.IsCarBooked = true;
        //     return CheckBooked(context);
        // }

        // protected override void ConfigureHowToFindSaga(SagaPropertyMapper<HolidayBookingData> mapper)
        // {
        //     mapper.ConfigureMapping<FlightBooked>(m => m.HolidayId).ToSaga(s => s.HolidayId);
        //     mapper.ConfigureMapping<HotelBooked>(m => m.HolidayId).ToSaga(s => s.HolidayId);
        //     mapper.ConfigureMapping<CarBooked>(m => m.HolidayId).ToSaga(s => s.HolidayId);
        // }

        // private async Task CheckBooked(IMessageHandlerContext context)
        // {
        //     if (Data.IsFlightBooked && Data.IsHotelBooked && Data.IsCarBooked)
        //     {
        //         await context.Publish(new HolidayBooked { HolidayId = Data.HolidayId });
        //         MarkAsComplete();
        //     }
        // }

        // public class HolidayBookingData : ContainSagaData
        // {
        //     public Guid HolidayId { get; set; }
        //     public bool IsFlightBooked { get; set; }
        //     public bool IsHotelBooked { get; set; }
        //     public bool IsCarBooked { get; set; }
        // }
    }
}

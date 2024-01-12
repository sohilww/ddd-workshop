using Ackee.Domain.Model;
using Booking.Domain.TeacherCalendars.Exceptions;


namespace Booking.Domain.TeacherCalendars
{
    public class TeacherCalendar : IAggregateRoot
    {
        public TeacherCalendar(
            DateOnly fromDate,
            DateOnly toDate,
            List<DayOfWeek> availableWeeks
            )
        {
            SetFromToDate(fromDate, toDate);

            AvailableWeeks = availableWeeks;

        }

        private void SetFromToDate(DateOnly fromDate, DateOnly toDate)
        {
            if (fromDate < DateOnly.FromDateTime(DateTime.Now))
                throw new FromDateIsBeforeTodayException();
            if (toDate < DateOnly.FromDateTime(DateTime.Now))
                throw new FromDateIsBeforeTodayException();
            if (toDate < fromDate)
                throw new ToDateShouldBeAfterFromDateException();
            FromDate = fromDate;
            ToDate = toDate;
        }

        public DateOnly FromDate { get; private set; }
        public DateOnly ToDate { get; private set; }

        public List<DayOfWeek> AvailableWeeks { get; set; }



        public void Publish<TEvent>(TEvent @event) where TEvent : IDomainEvent
        {
            throw new NotImplementedException();
        }
    }
}

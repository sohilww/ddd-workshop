using Booking.Domain.TeacherCalendars.Exceptions;


namespace Booking.Domain.TeacherCalendars
{
    public class TeacherCalendar
    {
        public TeacherCalendar(DateOnly fromDate, DateOnly toDate)
        {
            if (fromDate < DateOnly.FromDateTime(DateTime.Now))
                throw new FromDateIsBeforeTodayException();
            if (toDate < fromDate)
                throw new ToDateShouldBeAfterFromDateException();
            FromDate = fromDate;
            ToDate = toDate;

        }
        public DateOnly FromDate { get; private set; }
        public DateOnly ToDate { get; }
    }
}

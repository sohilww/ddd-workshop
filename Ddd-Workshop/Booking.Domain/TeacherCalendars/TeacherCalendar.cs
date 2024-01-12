namespace Booking.Domain.TeacherCalendars
{
    public class TeacherCalendar
    {
        public TeacherCalendar(DateOnly fromDate, DateOnly toDate)
        {
            FromDate = fromDate;
            ToDate = toDate;
        }
        public DateOnly FromDate { get; private set; }
        public DateOnly ToDate { get; }
    }
}

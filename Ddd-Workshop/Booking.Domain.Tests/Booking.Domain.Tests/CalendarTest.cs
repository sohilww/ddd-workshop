using System;
using System.Globalization;
using Booking.Domain.TeacherCalendars;
using Booking.Domain.TeacherCalendars.Exceptions;

namespace Booking.Domain.Tests
{
    [TestClass]
    public class CalendarTest
    {
        [TestMethod]
        public void Constructor_ShouldInitialFromDate()
        {
            DateOnly dateOnly = new DateOnly(2020,1,12);

            TeacherCalendar calendar = createCalendar(fromDate : dateOnly);
            Assert.AreEqual(dateOnly,calendar.FromDate);
        }
        [TestMethod]
        public void Constructor_ShouldInitialToDate()
        {
            DateOnly dateOnly = new DateOnly(2020, 1, 25);

            TeacherCalendar calendar = createCalendar(toDate: dateOnly);
            Assert.AreEqual(dateOnly, calendar.ToDate);
        }

        [TestMethod]
        [ExpectedException(typeof( ToDateShouldBeAfterFromDateException))]
        public void Constructor_ShouldThrowException_WhenToDateIsBeforeFromDate()
        {
            DateOnly fromDate = new DateOnly(2020, 1, 25);
            DateOnly toDate = new DateOnly(2020, 1, 26);
            TeacherCalendar calendar = createCalendar(fromDate: fromDate,toDate: toDate);
        }


        private TeacherCalendar createCalendar(DateOnly? fromDate=null , DateOnly? toDate = null)
        {
            if (!fromDate.HasValue)
                fromDate = new DateOnly(2020, 1, 12);
            if (!toDate.HasValue)
                toDate = new DateOnly(2020, 1, 12);
          return  new TeacherCalendar(fromDate.Value, toDate.Value);
        }
    }
}
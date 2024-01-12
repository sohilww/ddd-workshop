//using System;
//using System.Globalization;
//using Booking.Domain.TeacherCalendars;
//using Booking.Domain.TeacherCalendars.Exceptions;
//using Microsoft.QualityTools.Testing.Fakes;

//namespace Booking.Domain.Tests
//{
//    [TestClass]
//    public class CalendarTest
//    {
//        [TestMethod]
//        public void Constructor_ShouldInitialFromDate()
//        {
//            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now.AddDays(1)); 

//            TeacherCalendar calendar = createCalendar(fromDate: dateOnly);
//            Assert.AreEqual(dateOnly, calendar.FromDate);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(FromDateIsBeforeTodayException))]
//        public void Constructor_ShouldInitialFromDate_WhenFromDateIsBeforeToday()
//        {
//            using (ShimsContext.Create())
//            {
//                DateOnly dateOnly = new DateOnly(2020, 1, 12);

//                DateTime requestDateTime = new DateTime(2020, 1, 13, 12, 20, 30, 144, 134);
//                System.Fakes.ShimDateTime.NowGet = () => requestDateTime;

//                createCalendar(fromDate: dateOnly);
//            }

//        }
//        [TestMethod]
//        public void Constructor_ShouldInitialToDate()
//        {
//            DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now.AddDays(10)); ;

//            TeacherCalendar calendar = createCalendar(toDate: dateOnly);
//            Assert.AreEqual(dateOnly, calendar.ToDate);
//        }

//        [TestMethod]
//        [ExpectedException(typeof(ToDateShouldBeAfterFromDateException))]
//        public void Constructor_ShouldThrowToDateShouldBeAfterFromDateException_WhenToDateIsBeforeFromDate()
//        {
//            DateOnly fromDate = DateOnly.FromDateTime(DateTime.Now.AddDays(10));
//            DateOnly toDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1));
//            createCalendar(fromDate: fromDate, toDate: toDate);
//        }


//        private TeacherCalendar createCalendar(DateOnly? fromDate = null, DateOnly? toDate = null)
//        {
//            if (!fromDate.HasValue)
//                fromDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1)); 
//            if (!toDate.HasValue)
//                toDate = DateOnly.FromDateTime(DateTime.Now.AddDays(10));
//            return new TeacherCalendar(fromDate.Value, toDate.Value);
//        }
//    }
//}
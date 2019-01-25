using Fluent.DateTimeExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fluent.NextDateTimeExtensions.Test
{
    [TestClass]
    public class PastTest
    {
        [TestMethod]
        public void NextMonthNextYear()
        {
            const int MONTH = 1;
            var now = new DateTime(2017, 10, 1, 10, 20, 30);
            var dateTime = now.GetNextMonth(MONTH);

            Assert.AreEqual(dateTime.Month, MONTH);
            Assert.AreEqual(dateTime.Year, now.Year + 1);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextDayNextMonth()
        {
            const int DAY = 5;
            var now = new DateTime(2017, 1, 10, 10, 20, 30);
            var dateTime = now.GetNextDay(DAY);

            Assert.AreEqual(dateTime.Day, DAY);
            Assert.AreEqual(dateTime.Month, now.Month + 1);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextWeekNextMonth()
        {
            const DayOfWeek week = DayOfWeek.Sunday;
            var now = new DateTime(2017, 1, 02, 10, 20, 30);
            var dateTime = now.GetNextWeekDay(week);

            Assert.AreEqual(dateTime.DayOfWeek, week);
            Assert.AreEqual(dateTime.DayOfWeek.GetHashCode(), (now.DayOfWeek.GetHashCode() + 6) % 7);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextHourNextDay()
        {
            const int HOUR = 5;
            var now = new DateTime(2017, 1, 10, 10, 20, 30);
            var dateTime = now.GetNextHour(HOUR);

            Assert.AreEqual(dateTime.Hour, HOUR);
            Assert.AreEqual(dateTime.Day, now.Day + 1);

            Assert.AreEqual(dateTime.Year, now.Year);
            Assert.AreEqual(dateTime.Month, now.Month);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextMinuteNextHour()
        {
            const int MINUTE = 5;
            var now = new DateTime(2017, 1, 10, 10, 20, 30);
            var dateTime = now.GetNextMinute(MINUTE);

            Assert.AreEqual(dateTime.Minute, MINUTE);
            Assert.AreEqual(dateTime.Hour, now.Hour + 1);

            Assert.AreEqual(dateTime.Year, now.Year);
            Assert.AreEqual(dateTime.Month, now.Month);
            Assert.AreEqual(dateTime.Day, now.Day);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextSecondNextMinute()
        {
            const int SECOND = 5;
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextSecond(SECOND);

            Assert.AreEqual(dateTime.Second, SECOND);
            Assert.AreEqual(dateTime.Minute, now.Minute + 1);

            Assert.AreEqual(dateTime.Year, now.Year);
            Assert.AreEqual(dateTime.Month, now.Month);
            Assert.AreEqual(dateTime.Day, now.Day);
            Assert.AreEqual(dateTime.Hour, now.Hour);
        }
    }
}
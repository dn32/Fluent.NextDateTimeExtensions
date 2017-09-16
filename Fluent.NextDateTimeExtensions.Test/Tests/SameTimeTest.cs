using Fluent.DateTimeExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fluent.NextDateTimeExtensions.Test
{
    [TestClass]
    public class SameTimeTest
    {
        [TestMethod]
        public void NextMonthInTheSameYear()
        {
            const int MONTH = 5;
            var now = new DateTime(2017, 1, 1, 10, 20, 30);
            var dateTime = now.GetNextMoth(MONTH);

            Assert.AreEqual(dateTime.Month, MONTH);
            Assert.AreEqual(dateTime.Year, now.Year);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextDayThatSameMonth()
        {
            const int DAY = 5;
            var now = new DateTime(2017, 1, 1, 10, 20, 30);
            var dateTime = now.GetNextDay(DAY);

            Assert.AreEqual(dateTime.Day, DAY);
            Assert.AreEqual(dateTime.Month, now.Month);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextWeekThatSameMonth()
        {
            const DayOfWeek week = DayOfWeek.Monday;
            var now = new DateTime(2017, 1, 1, 10, 20, 30);
            var dateTime = now.GetNextWeekDay(week);

            Assert.AreEqual(dateTime.DayOfWeek, week);
            Assert.AreEqual(dateTime.Day, now.Day + 1);

            Assert.AreEqual(dateTime.Hour, now.Hour);
            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextHourThatSameDay()
        {
            const int HOUR = 5;
            var now = new DateTime(2017, 1, 1, 1, 20, 30);
            var dateTime = now.GetNextHour(HOUR);

            Assert.AreEqual(dateTime.Hour, HOUR);
            Assert.AreEqual(dateTime.Day, now.Day);

            Assert.AreEqual(dateTime.Minute, now.Minute);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextMinuteThatSameHour()
        {
            const int MINUTE = 5;
            var now = new DateTime(2017, 1, 1, 1, 1, 30);
            var dateTime = now.GetNextMinute(MINUTE);

            Assert.AreEqual(dateTime.Minute, MINUTE);
            Assert.AreEqual(dateTime.Hour, now.Hour);

            Assert.AreEqual(dateTime.Year, now.Year);
            Assert.AreEqual(dateTime.Month, now.Month);
            Assert.AreEqual(dateTime.Day, now.Day);
            Assert.AreEqual(dateTime.Second, now.Second);
        }

        [TestMethod]
        public void NextSecondThatSameMinute()
        {
            const int SECOND = 5;
            var now = new DateTime(2017, 1, 1, 1, 1, 1);
            var dateTime = now.GetNextSecond(SECOND);

            Assert.AreEqual(dateTime.Second, SECOND);
            Assert.AreEqual(dateTime.Minute, now.Minute);

            Assert.AreEqual(dateTime.Year, now.Year);
            Assert.AreEqual(dateTime.Month, now.Month);
            Assert.AreEqual(dateTime.Day, now.Day);
            Assert.AreEqual(dateTime.Hour, now.Hour);
        }
    }
}

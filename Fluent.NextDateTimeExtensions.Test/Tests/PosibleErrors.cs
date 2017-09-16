using Fluent.DateTimeExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fluent.NextDateTimeExtensions.Test.Tests
{
    [TestClass]
    public class PosibleErrors
    {
        [TestMethod]
        public void ErrorTimeInGetNextMoth()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextMoth(99, 99, 99, 99, 99);

            Assert.AreEqual(dateTime.Month, 12);
            Assert.AreEqual(dateTime.Day, 31);
            Assert.AreEqual(dateTime.Hour, 23);
            Assert.AreEqual(dateTime.Minute, 59);
            Assert.AreEqual(dateTime.Second, 59);
        }

        [TestMethod]
        public void ErrorTimeInGetNextDay()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextDay(99, 99, 99, 99);

            Assert.AreEqual(dateTime.Day, 31);
            Assert.AreEqual(dateTime.Hour, 23);
            Assert.AreEqual(dateTime.Minute, 59);
            Assert.AreEqual(dateTime.Second, 59);
        }

        [TestMethod]
        public void ErrorTimeInGetNextWeekDay()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextWeekDay(DayOfWeek.Sunday, 99, 99, 99);

            Assert.AreEqual(dateTime.Hour, 23);
            Assert.AreEqual(dateTime.Minute, 59);
            Assert.AreEqual(dateTime.Second, 59);
        }

        [TestMethod]
        public void ErrorTimeInGetNextHour()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextHour(99, 99, 99);

            Assert.AreEqual(dateTime.Hour, 23);
            Assert.AreEqual(dateTime.Minute, 59);
            Assert.AreEqual(dateTime.Second, 59);
        }

        [TestMethod]
        public void ErrorTimeInGetNextMinute()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextMinute(99, 99);

            Assert.AreEqual(dateTime.Minute, 59);
            Assert.AreEqual(dateTime.Second, 59);
        }


        [TestMethod]
        public void ErrorTimeInGetNextSecond()
        {
            var now = new DateTime(2017, 1, 10, 10, 20, 10);
            var dateTime = now.GetNextSecond(99);

            Assert.AreEqual(dateTime.Second, 59);
        }
    }
}
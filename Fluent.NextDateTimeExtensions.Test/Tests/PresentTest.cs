using Fluent.DateTimeExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fluent.NextDateTimeExtensions.Test
{
    [TestClass]
    public class PresentTest
    {
        [TestMethod]
        public void PresentMonth()
        {
            const int MONTH = 1;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextMonth(MONTH);

            Assert.AreEqual(dateTime, now);
        }

        [TestMethod]
        public void PresentDay()
        {
            const int DAY = 2;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextDay(DAY);

            Assert.AreEqual(dateTime, now);
        }

        [TestMethod]
        public void PresentWeek()
        {
            const DayOfWeek WEEK = DayOfWeek.Monday;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextWeekDay(WEEK);

            Assert.AreEqual(dateTime, now);
        }

        [TestMethod]
        public void PresentHour()
        {
            const int HOUR = 3;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextHour(HOUR);

            Assert.AreEqual(dateTime, now);
        }

        [TestMethod]
        public void PresentMinute()
        {
            const int MINUTE = 4;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextMinute(MINUTE);

            Assert.AreEqual(dateTime, now);
        }

        [TestMethod]
        public void PresentSecond()
        {
            const int SECOND = 5;
            var now = new DateTime(2017, 1, 2, 3, 4, 5);
            var dateTime = now.GetNextSecond(SECOND);

            Assert.AreEqual(dateTime, now);
        }
    }
}

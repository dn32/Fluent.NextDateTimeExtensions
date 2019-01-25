using System;

namespace Fluent.DateTimeExtensions
{
    /// <summary>
    /// Gets the next occurrence for a specific date and time.
    /// </summary>
    public static class NextDateTimeExtensions
    {
        /// <summary>
        /// Get the next date time of specified month.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="month">The month.</param>
        /// <param name="day">The Day.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="min">The minute.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextMonth(this DateTime dt, int month, int? day = null, int? hour = null, int? min = null, int? sec = null)
        {
            day = day ?? dt.Day;
            hour = hour ?? dt.Hour;
            min = min ?? dt.Minute;
            sec = sec ?? dt.Second;
            min = min > 59 ? 59 : min;
            sec = sec > 59 ? 59 : sec;
            hour = hour > 23 ? 23 : hour;
            month = month > 12 ? 12 : month;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            day = day > DateTime.DaysInMonth(dt.Year, dt.Month) ? DateTime.DaysInMonth(dt.Year, dt.Month) : day;
            var date = new DateTime(dt.Year, month, day.Value, hour.Value, min.Value, sec.Value);
            return date.DateIsEarlier(dt) ? date.AddYears(1) : date;
        }

        /// <summary>
        /// Get the next date time of specified day.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="day">The Day.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="min">The minute.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextDay(this DateTime dt, int day, int? hour = null, int? min = null, int? sec = null)
        {
            hour = hour ?? dt.Hour;
            min = min ?? dt.Minute;
            sec = sec ?? dt.Second;
            min = min > 59 ? 59 : min;
            sec = sec > 59 ? 59 : sec;
            hour = hour > 23 ? 23 : hour;
            day = day > 31 ? 31 : day;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            day = day > DateTime.DaysInMonth(dt.Year, dt.Month) ? DateTime.DaysInMonth(dt.Year, dt.Month) : day;
            var date = new DateTime(dt.Year, dt.Month, day, hour.Value, min.Value, sec.Value);
            return date.DateIsEarlier(dt) ? date.AddMonths(1) : date;
        }

        /// <summary>
        /// Get the next date time of specified day of week.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="dayOfWeek">The day os week.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="min">The minute.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextWeekDay(this DateTime dt, DayOfWeek dayOfWeek, int? hour = null, int? min = null, int? sec = null)
        {
            hour = hour ?? dt.Hour;
            min = min ?? dt.Minute;
            sec = sec ?? dt.Second;
            min = min > 59 ? 59 : min;
            sec = sec > 59 ? 59 : sec;
            hour = hour > 23 ? 23 : hour;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            var dtNew = new DateTime(dt.Year, dt.Month, dt.Day, hour.Value, min.Value, sec.Value);
            var daysUntilTuesday = (dayOfWeek.GetHashCode() - (int)dtNew.DayOfWeek + 7) % 7;
            var date = dtNew.AddDays(daysUntilTuesday);
            return date.DateIsEarlier(dt) ? date.AddDays(7) : date;
        }

        /// <summary>
        /// Get the next date time of specified hour.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="hour">The hour.</param>
        /// <param name="min">The minute.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextHour(this DateTime dt, int hour, int? min = null, int? sec = null)
        {
            min = min ?? dt.Minute;
            sec = sec ?? dt.Second;
            min = min > 59 ? 59 : min;
            sec = sec > 59 ? 59 : sec;
            hour = hour > 23 ? 23 : hour;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            var date = new DateTime(dt.Year, dt.Month, dt.Day, hour, min.Value, sec.Value);
            return date.DateIsEarlier(dt) ? date.AddDays(1) : date;
        }

        /// <summary>
        /// Get the next date time of specified minute.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="min">The minute.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextMinute(this DateTime dt, int min, int? sec = null)
        {
            sec = sec ?? dt.Second;
            min = min > 59 ? 59 : min;
            sec = sec > 59 ? 59 : sec;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            var date = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, min, sec.Value);
            return date.DateIsEarlier(dt) ? date.AddHours(1) : date;
        }

        /// <summary>
        /// Get the next date time of specified second.
        /// </summary>
        /// <param name="dt">The DateTime object to be handled.</param>
        /// <param name="sec">The second.</param>
        /// <returns>The resulting datetime.</returns>
        public static DateTime GetNextSecond(this DateTime dt, int sec)
        {
            sec = sec > 59 ? 59 : sec;
            dt = dt.AddMilliseconds(-1 * dt.Millisecond);

            var date = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, sec);
            return date.DateIsEarlier(dt) ? date.AddMinutes(1) : date;
        }

        private static bool DateIsEarlier(this DateTime dt1, DateTime dt2)
        {
            return new DateTime(dt1.Year, dt1.Month, dt1.Day, dt1.Hour, dt1.Minute, dt1.Second) < new DateTime(dt2.Year, dt2.Month, dt2.Day, dt2.Hour, dt2.Minute, dt2.Second);
        }
    }
}

using Fluent.DateTimeExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fluent.NextDateTimeExtensions.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var dt = DateTime.Now;

                Console.WriteLine(" ");
                Console.WriteLine("Future");

                Console.WriteLine("Month 1: " + dt.GetNextMoth(1));
                Console.WriteLine("Day 10: " + dt.GetNextDay(10));
                Console.WriteLine("Week 0: " + dt.GetNextWeekDay(DayOfWeek.Friday));
                Console.WriteLine("Hour 10: " + dt.GetNextHour(10));
                Console.WriteLine("Min 30: " + dt.GetNextMinute(30));
                Console.WriteLine("Sec 10: " + dt.GetNextSecond(10));

                Console.WriteLine(" ");
                Console.WriteLine("Currently");

                Console.WriteLine("Month: " + dt.GetNextMoth(DateTime.Now.Month));
                Console.WriteLine("Week: " + dt.GetNextWeekDay(DateTime.Now.DayOfWeek));
                Console.WriteLine("Hour: " + dt.GetNextHour(DateTime.Now.Hour));
                Console.WriteLine("Min: " + dt.GetNextMinute(DateTime.Now.Minute));
                Console.WriteLine("Sec: " + dt.GetNextSecond(DateTime.Now.Second));

                Console.WriteLine(" ");
                Console.WriteLine("Future");

                Console.WriteLine("Month: " + dt.GetNextMoth(DateTime.Now.Month + 1));
                Console.WriteLine("Week: " + dt.GetNextWeekDay(DateTime.Now.DayOfWeek + 1));
                Console.WriteLine("Hour: " + dt.GetNextHour(DateTime.Now.Hour + 1));
                Console.WriteLine("Min: " + dt.GetNextMinute(DateTime.Now.Minute + 1));
                Console.WriteLine("Sec: " + dt.GetNextSecond(DateTime.Now.Second + 1));

                Thread.Sleep(1000);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEnumDemo
{
    enum Days
    {
        Sat = 0,
        Sun,
        Mon= 13432,
        Tue,
        Wed,
        Thu,
        Fri
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Days> days = new List<Days>();
            days.Add(Days.Mon);
            days.Add(Days.Fri);
            days.Add(Days.Sun);

            Greeting(days);

            Console.WriteLine((int)Days.Mon);
        }

        static void Greeting(List<Days> days)
        {
            days.ForEach(day => Console.WriteLine("Hello " + day));
        }
    }
}

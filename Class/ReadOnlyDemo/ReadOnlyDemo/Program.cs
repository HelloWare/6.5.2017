using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldTime worldTime = new WorldTime(10);
            Console.WriteLine(worldTime.CurrentTime);
            worldTime.WeekdayCount = 12;
            Console.WriteLine(worldTime.WeekdayCount);

        }
    }
    class WorldTime
    {
        readonly DateTime currentTime = DateTime.Now;
        int weekdayCount = 5;

        public WorldTime(int weekday)
        {
            weekdayCount = weekday;
        }
        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
        }

        public int WeekdayCount
        {
            get
            {
                return weekdayCount;
            }
        }
    }
}

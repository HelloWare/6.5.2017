using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooncake
{
    class Program
    {
        static void Main(string[] args)
        {
            Mooncake mooncake = new Mooncake();
            mooncake.Radius = 2;
            mooncake.Stuffing = "fruit";
            mooncake.Wrap = "wheat";

            mooncake.Cook();
        }
    }

    class Mooncake
    {
        double radius = 0;
        string stuffing = "";
        string wrap = "";

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public string Stuffing
        {
            get
            {
                return stuffing;
            }

            set
            {
                stuffing = value;
            }
        }

        public string Wrap
        {
            get
            {
                return wrap;
            }

            set
            {
                wrap = value;
            }
        }

        public void Cook()
        {
            double time = 0;

            time += DetermineTimeOnSize();

            time += DetermineTimeOnStuffing();

            time += DetermineTimeOnWrap();

            Console.WriteLine("it takes {0} minutes to make a mooncake of {1}cm radius with {2} stuffing and {3} wrapper.", time, radius, stuffing, wrap);
        }

        private double DetermineTimeOnWrap()
        {
            if (wrap == "corn flour")
            {
                return 4;
            }
            if (wrap == "wheat")
            {
                return 5;
            }
            return 0;
        }

        private double DetermineTimeOnStuffing()
        {
            double time = 0;

            if (stuffing == "fruit")
            {
                time += 11;
            }
            if (stuffing == "nuts")
            {
                time += 15;
            }
            if (stuffing == "mix")
            {
                time += 13;
            }

            return time;
        }

        private double DetermineTimeOnSize()
        {
            double time = 0;
            if (radius == 2)
            {
                time += 2;
            }
            if (radius == 3)
            {
                time += 3;
            }
            if (radius == 4)
            {
                time += 4;
            }

            return time;
        }
    }
}

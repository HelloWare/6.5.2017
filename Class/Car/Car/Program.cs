using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Drive();
            Console.WriteLine(myCar.Acceleration);
        }
    }

    class Car
    {
        private readonly double a = 20;
        public double Acceleration
        {
            get
            {
                return a;
            }
        }
        public void Drive()
        {

        }
        public void Reverse()
        {

        }
    }

}

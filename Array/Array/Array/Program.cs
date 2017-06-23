using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {


            Car[] carArray = new Car[4];
            Car[] carArrayReplica;

            for (int i = 0; i < carArray.Length; i++)
            {
                Car carTemp = new Car();
                carArray[i] = carTemp;
            }

            foreach (Car car in carArray)
            {
                car.Year = 2017;
            }

            //Other operations

            foreach (Car car in carArray)
            {
                Console.WriteLine(car.Year);
            }

            carArrayReplica = carArray;

            for (int i = 0; i < carArrayReplica.Length-1; i++)
            {
                carArrayReplica[i].Year = 2018;
            }

            foreach (Car car in carArray)
            {
                Console.WriteLine(car.Year);
            }
        }
    }

    class Car
    {
        int year;

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }
    }
}

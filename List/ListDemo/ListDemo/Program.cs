using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list1 = new List<object>();
            List<Customer> list2 = new List<Customer>();
            List<int> list3 = new List<int>();

            List<Car> garage = new List<Car>();
            garage.Add(new Car("Car1"));
            garage.Add(new Car("Car2"));

            List<Car> newGarage = new List<Car> { new Car("Car3"), new Car("Car4") };

            garage.AddRange(newGarage);

            garage.Insert(0, new Car("Car0"));

            garage.RemoveAt(2);

            garage.ForEach(car => Console.WriteLine(car));
            //foreach (Car car in garage)
            //{
            //    Console.WriteLine(car);
            //}
        }
    }

    public class Customer
    {
    }

    public class Car
    {
        private string name;

        public Car(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Car:" + name;
        }
    }
}

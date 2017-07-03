using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new Car();
                Console.WriteLine(car.MyEngine.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Some Object is Null");
            }
            catch (Exception)
            {
                Console.WriteLine("Some exception happened");
            }
            finally
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
    class Engine
    {
        public string Name { get; set; }
    }
    class Car
    {
        public Engine MyEngine { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Toyota", "2004", "Highlander");
            vehicle.Start();
            vehicle.Accelerate(4, 4);
            vehicle.Accelerate(6, 3);
            Console.WriteLine("Speed is {0}", vehicle.Speed);
            vehicle.Deccelerate(3, 3);
            vehicle.Start(); //Car can't be started at this point
            Console.WriteLine("Speed is {0}", vehicle.Speed);
            vehicle.Stop(3.0); //Time
            //vehicle.Stop(3.0m); //Distance
            vehicle.Start();//you can re-start the car, because the car is stopped. 


            Vehicle vehicle2 = new Vehicle(year: "2008");
            Console.WriteLine(vehicle2.Make);
        }
    }

   class Vehicle
    {
        string make;
        string year;
        string model;
        double speed;

        public Vehicle(string make ="BMW", string year="2000", string model="X5")
        {
            this.make = make;
            this.year = year;
            this.model = model;
        }
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }
        }

        public string Year
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

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
        }

        public void Start()
        {
            if(speed != 0)
            {
                Console.WriteLine("Can't start the car, the car is moving");
                return;
            }
            Console.WriteLine("Car started");
        }
        public void Accelerate(double acc, double time)
        {
            speed += acc * time;
            Console.WriteLine("The car is accelerating at {0} m/s^2 for {1} s", acc, time);
        }
        public void Deccelerate(double dec, double time)
        {
            speed -= Math.Abs(dec) * time;
            Console.WriteLine("The car is deccelerating at {0} m/s^2 for {1} s", dec, time);
        }
        public void Stop(double time)
        {
            //caculate the decelerate needed
            double dec = speed / time;
            Console.WriteLine("The deccelerator needed to stop the car is {0}", dec);
            Deccelerate(dec, time);
        }
        public void Stop(decimal distance)
        {

        }
    }
}

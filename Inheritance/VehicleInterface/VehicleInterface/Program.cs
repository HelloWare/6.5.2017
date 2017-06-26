using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();
            bmw.AccelerationLimit = 30;
            Toyota toyota = new Toyota();
            toyota.AccelerationLimit = 20;

            Driver john = new Driver(toyota);
            john.StartAVehicle();
            john.AccelerateAVehicle();
            john.DeccelerateAVehicle();
            john.StopAVehicle();

            john.Vehicle = bmw;
            john.StartAVehicle();
            john.AccelerateAVehicle();
            john.DeccelerateAVehicle();
            john.StopAVehicle();
        }
    }

    public interface IVehicle
    {
        double AccelerationLimit { get; set; }

        void Start();
        void Stop();
        void Accelerate();
        void Decelerate();
    }
    public class BMW : IVehicle
    {
        public double AccelerationLimit
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Decelerate()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Toyota : IVehicle
    {
        public double AccelerationLimit
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void Decelerate()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
    public class Driver
    {
        private IVehicle vehicle;

        public IVehicle Vehicle
        {
            get
            {
                return vehicle;
            }

            set
            {
                vehicle = value;
            }
        }

        public Driver(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void StartAVehicle()
        {
            vehicle.Start();
        }

        public void StopAVehicle()
        {
            vehicle.Stop();
        }

        public void AccelerateAVehicle()
        {
            vehicle.Accelerate();
        }

        public void DeccelerateAVehicle()
        {
            vehicle.Decelerate();
        }
    }
}

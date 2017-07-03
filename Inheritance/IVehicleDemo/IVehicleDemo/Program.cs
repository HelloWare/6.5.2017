using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle bmw = new BMW();
            IVehicle toyota = new Toyota();

            Driver zhangSan = new Driver(bmw);
            zhangSan.StartAVehicle();
            zhangSan.AccelerateAVehicle();
            zhangSan.DecelerateAVehicle();
            zhangSan.StopAVehicle();

            zhangSan.Vehicle = toyota;
            zhangSan.StartAVehicle();
            zhangSan.AccelerateAVehicle();
            zhangSan.DecelerateAVehicle();
            zhangSan.StopAVehicle();

        }
    }

    interface IVehicle
    {
        int AccelerationLimit { get; set; }
        int DecelerationLimit { get; set; }
        int Speed { get; set; }
        void Start();
        void Accelerate();
        void Decelerate();
        void Stop();
    }
    class BMW : IVehicle
    {
        public int AccelerationLimit
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

        public int DecelerationLimit
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

        public int Speed
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

    class Toyota : IVehicle
    {
        public int AccelerationLimit
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

        public int DecelerationLimit
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

        public int Speed
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

    class Driver
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

        }
        public void AccelerateAVehicle()
        {

        }
        public void DecelerateAVehicle()
        {

        }
        public void StopAVehicle()
        {

        }
    }

}

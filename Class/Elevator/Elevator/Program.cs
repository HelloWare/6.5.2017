using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Door singleDoor = new SingleDoor();
            Elevator myElevator = new Elevator(20,singleDoor);
            myElevator.CurrentFloor = 11;
            myElevator.GoToFloor(10);

            myElevator.CurrentFloor = 11;
            myElevator.GoToFloor(20);


            FourValveEngine fourValveEngine = new FourValveEngine();
            Toyota myToyota = new Toyota(fourValveEngine);

            SixValveEngine sixValveEngine = new SixValveEngine();
            Toyota myToyota6V = new Toyota(sixValveEngine);
        }
    }
    abstract class Engine
    {

    }
    class FourValveEngine:Engine
    {

    }
    class SixValveEngine:Engine
    {
    }
    class Toyota
    {
        Engine engine;

        public Toyota(int engineNum)
        {

        }

        public Toyota(Engine engine)
        {
            this.engine = engine;
        }
        public Toyota(FourValveEngine fourValveEngine)
        {
            engine = fourValveEngine;
        }
        public Toyota(SixValveEngine sixValveEngine)
        {
            engine = sixValveEngine;
        }
    }

    abstract class Door
    {

    }

    class SingleDoor:Door
    {

    }
    class DoubleDoor:Door
    {

    }

    class Elevator
    {
        #region Fields
        int numOfFloors = 0;
        int speed = 0;
        double space = 0;
        double loadLimit = 0;
        double load = 0;
        bool hasCamera = false;
        int curFloor = 0;
        Door door = new DoubleDoor();
        #endregion

        #region Constructor
        public Elevator(int numOfFloors, Door door)
        {
            this.numOfFloors = numOfFloors;
            this.door = door;
        }
        public Elevator(int numOfFloors, double loadLimit)
        {
            this.numOfFloors = numOfFloors;
            this.loadLimit = loadLimit;
        }

        #endregion

        #region Java Properties
        public int GetCurrentFloor()
        {
            return curFloor;
        }
        public void SetCurrentFloor(int currentFloor)
        {
            this.curFloor = currentFloor;
        }
        #endregion
        #region Properties
        public int CurrentFloor
        {
            get { return curFloor; }
            set { curFloor = value; }
        }

        bool isOverload
        {
            get
            {
                return load > loadLimit;
            }            
        }
        #endregion

        #region Methods
        public void GoToFloor(int destinationFloor)
        {
            if (destinationFloor > numOfFloors)
                return;

            if(destinationFloor> curFloor)
            {
                Up(destinationFloor);
            }
            else
            {
                Down(destinationFloor);
            }
        }
        private void Up(int destinationFloor)
        {
            Console.WriteLine("You are going up to floor: " + destinationFloor);
        }
        private void Down(int destinationFloor)
        {
            Console.WriteLine("You are going down to floor: " + destinationFloor);
        }

        #endregion
    }
}

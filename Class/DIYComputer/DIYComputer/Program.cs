using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpu johnCpu = new Cpu();
            Motherboard zhangSanMotherboard = new Motherboard();
            Ram newEggRam = new Ram();
            Gpu gpu = new Gpu();
            PowerSupply oldPowerSupply = new PowerSupply();
            Monitor monitor = new Monitor();
            Keyboard keyboard = new Keyboard();
            Mouse mouse = new Mouse();

            DiyComputer myDiyComputer = new DiyComputer(johnCpu, zhangSanMotherboard, newEggRam, gpu, oldPowerSupply, monitor, keyboard, mouse);

            Cpu myNewCpu = new Cpu();
            myDiyComputer.Cpu = myNewCpu;

            DiyComputer hisComputer = new DiyComputer();
        }
    }
    
    class DiyComputer
    {
        //declaration
        Cpu cpu;
        Motherboard motherboard;
        Ram ram;
        Gpu gpu;
        PowerSupply powerSupply;
        Monitor monitor;
        Keyboard keyboard;
        Mouse mouse;

        public Cpu Cpu
        {
            get
            {
                return cpu;
            }

            set
            {
                cpu = value;
            }
        }

        public Motherboard Motherboard
        {
            get
            {
                return motherboard;
            }

            set
            {
                motherboard = value;
            }
        }

        public Ram Ram
        {
            get
            {
                return ram;
            }

            set
            {
                ram = value;
            }
        }

        public Gpu Gpu
        {
            get
            {
                return gpu;
            }

            set
            {
                gpu = value;
            }
        }

        public PowerSupply PowerSupply
        {
            get
            {
                return powerSupply;
            }

            set
            {
                powerSupply = value;
            }
        }

        public Monitor Monitor
        {
            get
            {
                return monitor;
            }

            set
            {
                monitor = value;
            }
        }

        public Keyboard Keyboard
        {
            get
            {
                return keyboard;
            }

            set
            {
                keyboard = value;
            }
        }

        public Mouse Mouse
        {
            get
            {
                return mouse;
            }

            set
            {
                mouse = value;
            }
        }

        //user has to supply all the compoments
        public DiyComputer(Cpu cpu, Motherboard motherboard,Ram ram, Gpu gpu,PowerSupply powerSupply, Monitor monitor, Keyboard keyboard,Mouse mouse)
        {
            //initialization
            this.cpu = cpu;
            this.motherboard = motherboard;
            this.ram = ram;
            this.gpu = gpu;
            this.powerSupply = powerSupply;
            this.monitor = monitor;
            this.keyboard = keyboard;
            this.mouse = mouse;
            Console.WriteLine("Computer Created!");
        }

        public DiyComputer():this(new Cpu(), new Motherboard(), new Ram(), new Gpu(), new PowerSupply(), new Monitor(), new Keyboard(), new Mouse())
        {
            Console.WriteLine("This is a default constructor");
        }

        //public DiyComputer()
        //{
        //    //initialization
        //    this.cpu = new Cpu();
        //    this.motherboard = new Motherboard();
        //    this.ram = new Ram();
        //    this.gpu = new Gpu();
        //    this.powerSupply = new PowerSupply();
        //    this.monitor = new Monitor();
        //    this.keyboard = new Keyboard();
        //    this.mouse = new Mouse();
        //}



    }
    class Cpu
    {

    }
    class Motherboard
    {

    }
    class Ram
    {

    }
    class Gpu
    {

    }
    class PowerSupply
    {

    }
    class Monitor
    {

    }
    class Keyboard
    {

    }
    class Mouse
    {

    }
}


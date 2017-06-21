using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIYComputer
{
    class Program
    {
        static Cpu BorrowJohnCpu()
        {
            return new Cpu() { Frequency = 3.5 };
        }
        static Motherboard BuyFromZhangSan()
        {
            return new Motherboard();
        }
        static void Main(string[] args)
        {
            Cpu johnCpu = BorrowJohnCpu();
            johnCpu.Frequency = 3.5;
            Motherboard zhangSanMotherboard = BuyFromZhangSan();
            Ram newEggRam = new Ram();
            Gpu gpu = new Gpu();
            PowerSupply oldPowerSupply = new PowerSupply();
            Monitor monitor = new Monitor();
            Keyboard keyboard = new Keyboard();
            Mouse mouse = new Mouse();

            DiyComputer myDiyComputer = new DiyComputer(johnCpu, zhangSanMotherboard, newEggRam, gpu, oldPowerSupply, monitor, keyboard, mouse);
            myDiyComputer.ShowConfig();

            Cpu myNewCpu = new Cpu();
            myNewCpu.Frequency = 4.0;
            myDiyComputer.Cpu = myNewCpu;
            myDiyComputer.ShowConfig();

            DiyComputer hisComputer = new DiyComputer();
            hisComputer.ShowConfig();

            Motherboard ebayMotherboard = new Motherboard();
            DiyComputer herComputer = new DiyComputer(motherboard: ebayMotherboard);

        }
    }
    
    class DiyComputer
    {
        //declaration + initialization
        Cpu cpu = new Cpu();
        Motherboard motherboard=new Motherboard ();
        Ram ram=new Ram ();
        Gpu gpu=new Gpu ();
        PowerSupply powerSupply=new PowerSupply();
        Monitor monitor = new Monitor();
        Keyboard keyboard =new Keyboard ();
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

        public DiyComputer():this(
            new Cpu() { Frequency = 3.2 },
            new Motherboard(),
            new Ram(), 
            new Gpu(),
            new PowerSupply(), 
            new Monitor(), 
            new Keyboard(),
            new Mouse())
        {
            Console.WriteLine("This is a default constructor");
        }

        public DiyComputer(Cpu cpu = null,Motherboard motherboard = null,Ram ram = null)
        {
            this.cpu = cpu ?? this.cpu;
            this.motherboard = motherboard ?? this.motherboard;
            this.ram = ram ?? this.ram;
        }

        public void ShowConfig()
        {
            Console.WriteLine("CPU has a frequency of {0}", this.cpu.Frequency);
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
       public Cpu()
        {
            Console.WriteLine("This is i5 CPU");
        }

        private double frequency;

        public double Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                frequency = value;
            }
        }

    }
    class Motherboard
    {
        public Motherboard()
        {
            Console.WriteLine("this is a Z270 motherboard");
        }
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


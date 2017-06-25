using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Solution
{
    class Program
    {
        static void PrintComputers(Computer[] computers)
        {
            Console.WriteLine();
            foreach (Computer computer in computers)
            {
                Console.WriteLine("Color: {0}, Size: {1}", computer.Color, computer.Size);
            }
        }
        static void Main(string[] args)
        {
            Computer[] computers = new Computer[10];

            for (int i = 0; i < computers.Length; i++)
            {
                computers[i] = new Computer("white", "large");
            }

            PrintComputers(computers);

            for (int i = 0; i < computers.Length/2; i++)
            {
                computers[i].Color = "Black";
            }

            PrintComputers(computers);


            Computer[] anotherComputerArray = computers;

            for (int i = 0; i < computers.Length / 2; i++)
            {
                anotherComputerArray[i].Size = "Small";
            }
            PrintComputers(computers);
            PrintComputers(anotherComputerArray);


        }
    }


    public class Computer
    {
        private string color;
        private string size;

        public Computer(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }
    }
}

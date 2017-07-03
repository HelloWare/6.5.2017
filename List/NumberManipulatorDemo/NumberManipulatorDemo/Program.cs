using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulatorDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Input
          string input="";
            List<double> numbers = new List<double>();
            do
            {
               input = Console.ReadLine();

                double number;
                bool isNumber = Double.TryParse(input, out number);

                if(isNumber)
                {
                    numbers.Add(number);
                }

            } while (input !="N");

            //process
            double sum = 0;
            foreach (double item in numbers)
            {
                sum += item;
            }

            numbers.Sort();

            double median = numbers[numbers.Count / 2];

            foreach (double item in numbers)
            {
                Console.Write(item+" ");
            }

            //Output
            Console.WriteLine(sum);
            Console.WriteLine(median);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int index = 2;

            int average = Average(a, b, index);
            Console.WriteLine(average);
            Console.Read();
        }

        public static int Average(int a, int b, int index)
        {
            int sum = 0;
            sum = (a + b);
            int average = Division(sum, index);
            return average;
        }

        public static int Division(int c, int d)
        {
            int div = 0;
            div = c/d;
            return div;
        }


    }
}

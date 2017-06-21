using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Setting.Increment();
            Console.WriteLine(Setting.BackgroundColor);
            ChangeBackgroundColor();
            Setting.Increment();
            Console.WriteLine(Setting.BackgroundColor);
        }

        private static void ChangeBackgroundColor()
        {
            Setting.Increment();
            Setting.BackgroundColor = "White";
        }
    }

    static class Setting
    {
        static private string backgroundColor = "Black";
        static private int baseNumber = 0;
        public static string BackgroundColor
        {
            get
            {
                return backgroundColor;
            }

            set
            {
                backgroundColor = value;
            }
        }

        static public void Increment()
        {
            Console.WriteLine(Math.Abs(++baseNumber));
        }
    }
}

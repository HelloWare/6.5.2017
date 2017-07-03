using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ReadTextDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HelloWare Academy\Desktop\test.txt");

            Console.WriteLine(text);


            var fileStream = new FileStream(@"C:\Users\HelloWare Academy\Desktop\test.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(2000);
                }
            }


        }
    }
}

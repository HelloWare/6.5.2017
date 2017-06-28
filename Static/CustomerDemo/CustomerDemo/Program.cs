using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "sdfsdfd";
            Console.WriteLine(text);
            //Customer customer1 = new Customer();
            Customer customer2 = Customer.GetCustomer("ZhangSan");
            Console.WriteLine("Customer 2: "+customer2.Name);
            Customer customer3 = Customer.GetCustomer("LiSi");
            Console.WriteLine("Customer 3: " + customer3.Name);
            customer3 = null; //?????
            Customer customer4 = Customer.GetCustomer("WangEr");
            Console.WriteLine("Customer 4: " + customer4.Name);
        }
    }

    //singleton pattern
    class Customer
    {
        string name;
        static Customer customer;
        private Customer()
        {          
            Console.WriteLine("This is a non-static constructor");
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public static Customer GetCustomer(string name)
        {
            Console.WriteLine("This is a static constructor");
            if (customer == null)
            {
                customer = new Customer();
                customer.name = name;
            }
            return customer;
        }
    }
}

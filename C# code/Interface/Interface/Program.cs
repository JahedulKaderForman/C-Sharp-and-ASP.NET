using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{



    interface ICustomer
    {
        void Print();
    }

    interface ICustomer2 : ICustomer
    {
        void Print2();
    }

    class Customer : ICustomer2
    {
        public void Print()
        {
            Console.WriteLine("Interface Hello World");
        }

        public void Print2()
        {
            Console.WriteLine("Interface2 Hello World");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Print();
            c1.Print2();
            ICustomer c2 = new Customer();
            c2.Print();
            Console.ReadKey();
        }
    }
}

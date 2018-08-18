using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    interface ICustomer
    {
        void print();
    }

    interface ICustomer2
    {
        void print();
    }

    class Customer : ICustomer, ICustomer2
    {
        void ICustomer.print()
        {
            Console.WriteLine("Interface1");
        }
        void ICustomer2.print()
        {
            Console.WriteLine("Interface2");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            ((ICustomer)customer).print();
            ((ICustomer2)customer).print();
            Console.ReadKey();
        }
    }
}

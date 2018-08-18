using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.setFistName("Forman");
            person.Firstname = "Forman";
            Console.WriteLine("First :" + person.Firstname);
            //Console.WriteLine(person.getFirstName());
            Console.ReadKey();
        }
    }
}

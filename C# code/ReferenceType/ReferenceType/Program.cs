using System;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person person= new Person("Forman", "khan");
            person.firstName = "Forman";
            person.lastName = "khan";
            person.age = 12;
            Console.WriteLine(person.firstName+" "+person.lastName+" ")

        }
    }
}

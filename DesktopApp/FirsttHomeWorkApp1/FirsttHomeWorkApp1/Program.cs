using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirsttHomeWorkApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
               
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("DOTNET ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("DOT ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("NET ");
                }
               
                else
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}

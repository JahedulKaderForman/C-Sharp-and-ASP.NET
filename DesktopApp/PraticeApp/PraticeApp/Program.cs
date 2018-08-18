using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PraticeApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            string numberReverse;
            Rverse(number);
            for(int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i]);
            }
        }

        public static stringReverseString2(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
    }
}

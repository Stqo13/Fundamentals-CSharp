using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._6
{
    class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            MiddleChar(text);
        }
        public static void MiddleChar(string text)
        {
            int length=text.Length;
            int middleIndex = length/2;

            if (length % 2 == 0)
            {
                Console.Write(text[middleIndex - 1]);
                Console.Write(text[middleIndex]);
            }
            else
            {
                Console.WriteLine(text[middleIndex]);
            }
        }
    }
}

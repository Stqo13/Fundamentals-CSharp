using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                if (char.IsDigit(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (char item in input)
            {
                if (char.IsLetter(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (char item in input)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    Console.Write(item);
                }
            }
        }
    }
}

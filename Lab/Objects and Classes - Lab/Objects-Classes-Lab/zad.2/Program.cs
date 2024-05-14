using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = 1;
            int factorial = int.Parse(Console.ReadLine());
            for (int i = 1; i <= factorial; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}

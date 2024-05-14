using System;
using System.Linq;
using System.Collections.Generic;
using System. Numerics;

namespace Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double divison = Division(first, second);
            Console.WriteLine($"{divison:f2}");
        }
        static long FirstFactorial(decimal first)
        {
            long factorial = 1;
            for (int i = 1; i <= first; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static long SecondFactorial(decimal second)
        {
            long factorialSecond = 1;
            for (int i = 1; i <= second; i++)
            {
                factorialSecond = factorialSecond * i;
            }
            return factorialSecond;
        }
        static double Division(long first, long second)
        {
            double divison = FirstFactorial(first)*1.0 / SecondFactorial(second);
            return divison;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Methods_Lab
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            NumberCheck(num);
        }
        static void NumberCheck(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}

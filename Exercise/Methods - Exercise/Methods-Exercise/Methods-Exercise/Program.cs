using System;
using System.Linq;
using System.Collections.Generic;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Comparison(first, second, third);
        }
        static void Comparison(int first,int second, int third)
        {
            if (first<=second && first<=third)
            {
                Console.WriteLine(first);
            }
            else if (second<=first && second<=third)
            {
                Console.WriteLine(second);
            }
            else if (third<=first && third<=second)
            {
                Console.WriteLine(third);
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = Sum(first, second);
            int division = Subtraction(sum, first, second, third);
            Console.WriteLine(division);
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Subtraction(int sum, int first,  int second, int third)
        {
            int division = Sum(first, second) - third;
            return division;
        }
    }
}

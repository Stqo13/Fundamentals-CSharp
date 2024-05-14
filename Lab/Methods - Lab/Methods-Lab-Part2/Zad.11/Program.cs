using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char mathOperator= char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double result = Operation(first, mathOperator, second);
            Console.WriteLine(result);
        }
        static double Operation(int first, char mathOperator, int second)
        {
            double result = 0;
            switch (mathOperator)
            {
                case '/':
                    result = first / second;
                    break;
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
            }
            return result;
        }
    }
}

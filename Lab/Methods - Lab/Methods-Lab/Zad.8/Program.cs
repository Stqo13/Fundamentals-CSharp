using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseNUM = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double numPower = Power(baseNUM, power);
            Console.WriteLine(numPower);
        }
        static double Power(double num, double power)
        {
            double numPower = Math.Pow(num, power);
            return numPower;
        }
    }
}

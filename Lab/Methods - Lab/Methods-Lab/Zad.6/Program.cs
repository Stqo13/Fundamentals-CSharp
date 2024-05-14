using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double area = Area(width, heigth);
            Console.WriteLine(area);
        }
        static double Area(double width, double heigth)
        {
            double area = width * heigth;
            return area;
        }
    }
}

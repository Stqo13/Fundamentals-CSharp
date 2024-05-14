using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintPrice(product, quantity);
        }
        static void PrintPrice(string product, int quantity)
        {
            double sum = 0;
            switch (product)
            {
                case "coffee":
                    sum = quantity * 1.50;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "water":
                    sum = quantity * 1.00;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "coke":
                    sum = quantity * 1.40;
                    Console.WriteLine($"{sum:f2}");
                    break;
                case "snacks":
                    sum = quantity * 2.00;
                    Console.WriteLine($"{sum:f2}");
                    break;
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Associative_Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numberOcc = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var number in input)
            {
                if (!numberOcc.ContainsKey(number))
                {
                    numberOcc.Add(number, 1);
                }
                else
                {
                    numberOcc[number] += 1;
                }
            }
            foreach (var item in numberOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

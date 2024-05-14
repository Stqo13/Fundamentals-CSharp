using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> vegetablesList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string vegetables = Console.ReadLine();
                vegetablesList.Add(vegetables);
            }
            vegetablesList.Sort();
            for (int i = 0; i < vegetablesList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{vegetablesList[i]}");
            }
        }
    }
}

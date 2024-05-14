using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (input!="stop")
            {
                int ammount = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(input))
                {
                    resources.Add(input, ammount);
                }
                else
                {
                    resources[input] += ammount;
                }
                input = Console.ReadLine();
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

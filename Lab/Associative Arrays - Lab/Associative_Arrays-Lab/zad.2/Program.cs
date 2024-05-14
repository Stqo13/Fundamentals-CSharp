using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string lowerCase = word.ToLower();
                if (count.ContainsKey(lowerCase))
                {
                    count[lowerCase] += 1;
                }
                else
                {
                    count.Add(lowerCase, 1);
                }
            }
            foreach (var (key, value) in count)
            {
                if (value % 2!=0)
                {
                    Console.Write($"{key} ");
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Associative_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charOcc = new Dictionary<char, int>();
            foreach (var ch in text)
            {
                if (ch==' ')
                {
                    continue;
                }
                else
                {
                    if (!charOcc.ContainsKey(ch))
                    {
                        charOcc.Add(ch, 1);
                    }
                    else
                    {
                        charOcc[ch] += 1;
                    }
                }
            }
            foreach (var item in charOcc)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

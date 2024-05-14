using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

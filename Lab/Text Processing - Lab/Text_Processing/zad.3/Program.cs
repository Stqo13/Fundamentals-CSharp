using System;
using System.Collections.Generic;
using System.Linq;

namespace zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string input = Console.ReadLine();
            while (input.Contains(specialWord))
            {
                int index = input.IndexOf(specialWord);
                input = input.Remove(index, specialWord.Length);
            }
            Console.WriteLine(input);
        }
    }
}

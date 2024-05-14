using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            AsciiBetween(first, second);
        }
        static void AsciiBetween(char first, char second)
        {
            int startCharacter = Math.Min(first, second);
            int endCharacter = Math.Max(first, second);


            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }

    }
}

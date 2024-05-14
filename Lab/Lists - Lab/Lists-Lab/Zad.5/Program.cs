using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int negativeCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeCount++;
                }
                if (negativeCount == numbers.Count)
                {
                    Console.WriteLine("empty");
                    return;
                }
            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i]<0)
                {
                    numbers.RemoveAt(i);
                }
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

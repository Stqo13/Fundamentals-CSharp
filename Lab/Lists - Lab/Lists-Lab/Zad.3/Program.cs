using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int minValue = Math.Min(firstList.Count, secondList.Count);
            for (int i = 0; i < minValue; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }
            if (firstList.Count>secondList.Count)
            {
                for (int i = minValue; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if (secondList.Count>firstList.Count)
            {
                for (int i = minValue; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

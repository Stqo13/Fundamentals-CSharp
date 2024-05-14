using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Processing_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = CodeMultiply(input);
            Console.WriteLine(result);
        }
        public static int CodeMultiply(string strings)
        {
            int sum = 0;
            string[] input = strings.Split(' ');
            int minLength = Math.Min(input[0].Length, input[1].Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += input[0][i] * input[1][i];
            }
            int maxLength = Math.Max(input[0].Length, input[1].Length);
            for (int i = minLength; i < maxLength; i++)
            {
                if (i >= input[0].Length)
                {
                    sum += input[1][i];
                }
                else if (i >= input[1].Length)
                {
                    sum += input[0][i];
                }
            }
            return sum;
        }
    }
}

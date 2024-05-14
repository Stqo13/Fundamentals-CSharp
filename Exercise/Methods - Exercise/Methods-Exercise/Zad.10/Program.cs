using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lastNumber; i++)
            {
                if (OneOddDigit(i)==true)
                {
                    if (FindDigitSum(i)==true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static bool OneOddDigit(int number)
        {
            bool itContains = false;
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                int currentNumber = number % 10;
                if (currentNumber%2!=0)
                {
                    itContains = true;
                }
                number = number / 10;
            }
            return itContains;
        }
        static bool FindDigitSum(int number)
        {
            bool sumIsValid = false;
            int digitSum = 0;
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                int currentNum = number % 10;
                number = number / 10;
                digitSum += currentNum;
            }
            if (digitSum % 8 == 0)
            {
                sumIsValid = true;
            }
            return sumIsValid;
        }
    }
}

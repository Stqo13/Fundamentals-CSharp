using System;

namespace Zad._10_Type2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int evenSum = GetSumOfEvenDigits(num, true);
            int oddSum = GetSumOfOddDigits(num, true);
            double multiplication = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(Math.Abs(multiplication));
        }
        static int GetSumOfEvenDigits(string numbers, bool isEven)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i]))
                {
                    int currentEven = int.Parse(numbers[i].ToString());
                    if (currentEven % 2 == 0 && isEven)
                    {
                        sum += currentEven;
                    }
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(string numbers, bool isOdd)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i]))
                {
                    int currentOdd = int.Parse(numbers[i].ToString());
                    if (currentOdd % 2 == 1 && isOdd)
                    {
                        sum += currentOdd;
                    }
                }
            }
            return sum;
        }
        static double GetMultipleOfEvenAndOdds(double evenSum, double oddSum)
        {
            double multiplication = evenSum * oddSum;
            return multiplication;
        }
    }
}

using System;

namespace Methods_Lab_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            while (num != 0)
            {
                int newNum = num % 10;
                num = num / 10;
                if (newNum % 2 == 0)
                {
                    evenSum += newNum;
                }
                else
                {
                    oddSum += newNum;
                }
            }
            double multiplication = Math.Abs(evenSum * oddSum);
            Console.WriteLine(multiplication);
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturaday", "Sunday" };
            int days = int.Parse(Console.ReadLine());
            if (days<1||days>7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(daysOfWeek[days-1]);
            
            zad2
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                arr[i] = numbers;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            
            zad3
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {(int)Math.Round(arr[i],MidpointRounding.AwayFromZero)}");
            }
            
            zad4
            //string[] arr = Console.ReadLine().Split().ToArray();
            //Array.Reverse(arr);
            //Console.Write(string.Join(" ", arr));
            string[] arr = Console.ReadLine().Split().ToArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }
            
            zad5
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int evenNums = arr[i];
                if (evenNums%2==0)
                {
                    sum += evenNums;
                }
            }
            Console.WriteLine($"{sum}");
            
            zad6
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int evenNums = arr[i];
                int oddNums = arr[i];
                if (evenNums % 2 == 0)
                {
                    evenSum += evenNums;
                }
                else
                {
                    oddSum += oddNums;
                }
            }
            result = evenSum - oddSum;
            Console.WriteLine(result);
            
            zad7
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentNum = arr1[i];
                if (arr1[i]!=arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                else if (arr1[i]==arr2[i])
                {
                    sum += currentNum;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            */

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length-1];
            if (arr.Length==1)
            {
                Console.WriteLine($"{arr[0]}");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < condensed.Length-i; j++)
                {
                    condensed[j] = arr[j] + arr[j + 1];
                }
                condensed = arr;
            }
            Console.WriteLine(condensed[0]);
        }
    }
}

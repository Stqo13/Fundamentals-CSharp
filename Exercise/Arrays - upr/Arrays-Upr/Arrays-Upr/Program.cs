using System;
using System.Linq;
using System.Collections.Generic;

namespace Arrays_Upr
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            int n = int.Parse(Console.ReadLine());
            int[] people = new int[n];
            int allPeople = 0;
            for (int i = 0; i < n; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                allPeople += people[i];
            }
            foreach (int item in people)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(allPeople);
            
            zad2
            string[] firstArr = Console.ReadLine().Split().ToArray();
            string[] secondArr = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j]==secondArr[i])
                    {
                        Console.Write($"{secondArr[i]} ");
                    }
                }
            }
            Console.WriteLine();
            
            zad3
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i%2!=0)
                {
                    first[i] = numbers[1];
                    second[i] = numbers[0];
                }
                else
                {
                    first[i] = numbers[0];
                    second[i] = numbers[1];
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
            
            zad4
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int firstNum = arr[0];
                for (int j = 0; j < arr.Length-1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", arr));
            
            zad5
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                bool isTop = true;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];
                    if (nextNum>=current)
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write(current + " ");
                }
            }
            
            zad6
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                rightSum = 0;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
            
            zad7
            string[] arr = Console.ReadLine().Split();
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentElement = arr[i];
                int currentCounter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentElement == arr[j])
                    {
                        currentCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter > bestCount)
                {
                    bestCount = currentCounter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }
            
            zad8
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int constant = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum = currentNumber + numbers[j];
                    if (sum == constant)
                    {
                        Console.Write($"{currentNumber} {numbers[j]}");
                        Console.WriteLine();
                    }
                }
            }
            */

        }
    }
}

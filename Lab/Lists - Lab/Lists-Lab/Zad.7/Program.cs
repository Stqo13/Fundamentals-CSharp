using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool changed = false;
            while (command != "end")
            {
                string[] commands = command.Split();
                switch (commands[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        changed = true;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]%2==0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]%2!=0)
                            {
                                Console.Write($"{numbers[i]} ");
                            }  
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = commands[1];
                        int number = int.Parse(commands[2]);
                        if (condition=="<")
                        {
                            foreach (var item in numbers)
                            {
                                if (item<number)
                                {
                                    Console.Write($"{item} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (condition == ">")
                        {
                            foreach (var item in numbers)
                            {
                                if (item > number)
                                {
                                    Console.Write($"{item} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (condition == ">=")
                        {
                            foreach (var item in numbers)
                            {
                                if (item >= number)
                                {
                                    Console.Write($"{item} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        else if (condition == "<=")
                        {
                            foreach (var item in numbers)
                            {
                                if (item <= number)
                                {
                                    Console.Write($"{item} ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            if (changed)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

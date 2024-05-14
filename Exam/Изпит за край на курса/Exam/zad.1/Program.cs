using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace zad._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="Finish")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string commandName = commandInfo[0];
                switch (commandName)
                {
                    case "Replace":
                        string currentChar = commandInfo[1];
                        string newChar = commandInfo[2];
                        input = input.Replace(currentChar, newChar);
                        Console.WriteLine(input);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commandInfo[1]);
                        int endIndex = int.Parse(commandInfo[2]);
                        if (startIndex >= 0 && startIndex <= input.Length - 1 && endIndex >= 0 && endIndex <= input.Length - 1)
                        {
                            input = input.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                    case "Make":
                        string look = commandInfo[1];
                        if (look=="Upper")
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
                        }
                        else if (look=="Lower")
                        {
                            input = input.ToLower();
                            Console.WriteLine(input);
                        }
                        break;
                    case "Check":
                        string text = commandInfo[1];
                        if (input.Contains(text))
                        {
                            Console.WriteLine($"Message contains {text}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {text}");
                        }
                        break;
                    case "Sum":
                        int start = int.Parse(commandInfo[1]);
                        int end = int.Parse(commandInfo[2]);
                        if (start >= 0 && start <= input.Length - 1 && end >= 0 && end <= input.Length - 1)
                        {
                            string substring = input.Substring(start, end - start + 1);
                            int sum = 0;
                            foreach (char ch in substring)
                            {
                                sum += (int)ch;
                            }
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indices!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }

        }
    }
}

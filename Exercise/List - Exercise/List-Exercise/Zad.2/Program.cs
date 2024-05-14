using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] commands = command.Split();
                switch (commands[0])
                {
                    case "Delete":
                        int element = int.Parse(commands[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]==element)
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                        break;
                    case "Insert":
                        int num = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        numbers.Insert(index, num);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

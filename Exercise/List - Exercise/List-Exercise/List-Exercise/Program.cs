using System;
using System.Linq;
using System.Collections.Generic;

namespace List_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command!="end")
            {
                string[] commands = command.Split();
                if (commands.Length == 1)
                {
                    int incomming = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (incomming +  wagons[i] <= maxCapacity)
                        {
                            wagons[i] += incomming;
                            break;
                        }
                    }
                }
                switch (commands[0])
                {
                   case "Add":
                      int passangers = int.Parse(commands[1]);
                      wagons.Add(passangers);
                   break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

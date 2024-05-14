using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split("||");
        string command = input[0];
        int distance = int.Parse(input[1]);
        int fuel = int.Parse(Console.ReadLine());
        int ammunition = int.Parse(Console.ReadLine());
        bool missionFailed = false;
        while (command != "Titan")
        {
            
        }

        if (!missionFailed)
        {
            Console.WriteLine("You have reached Titan, all passengers are safe.");
        }
    }
}

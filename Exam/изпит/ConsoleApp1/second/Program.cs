using System;
using System.Linq;
using System.Collections.Generic;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            string command = input[0];
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());
            bool missionFailed = false;
            while (command != "Titan")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    command = input[i];
                    string[] commands = command.Split();
                    switch (commands[0])
                    {
                        case "Travel":
                            int distance = int.Parse(commands[1]);
                            if (fuel >= distance)
                            {
                                fuel -= distance;
                                Console.WriteLine($"The spaceship travelled {distance} light-years.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                missionFailed = true;
                                return;
                            }
                            break;
                        case "Enemy":
                            int armour = int.Parse(commands[1]);
                            if (ammunition >= armour)
                            {
                                ammunition -= armour;
                                Console.WriteLine($"An enemy with {armour} armour is defeated.");
                            }
                            else if (ammunition < armour)
                            {
                                int fuelConsumed = 2 * armour;
                                if (fuel >= fuelConsumed)
                                {
                                    fuel-=fuelConsumed;
                                    Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
                                }
                                else
                                {
                                    Console.WriteLine("Mission failed.");
                                    missionFailed = true;
                                    return;
                                }
                            }
                            break;
                        case "Repair":
                            int fuelAdd = int.Parse(commands[1]);
                            int ammoAdd = int.Parse(commands[1]) *2;
                            fuel += fuelAdd;
                            ammunition += ammoAdd;
                            Console.WriteLine($"Ammunitions added: {ammoAdd}.");
                            Console.WriteLine($"Fuel added: {fuelAdd}.");
                            break;
                    }
                }
            }
            if (!missionFailed)
            {
                Console.WriteLine("You have reached Titan, all passengers are safe.");
            }
        }
    }
}

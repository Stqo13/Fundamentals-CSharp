using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingSlots = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] parkInfo = input.Split();
                string username = parkInfo[1];
                string plateNumber = string.Empty;
                if (parkInfo[0]!="unregister")
                {
                    plateNumber = parkInfo[2];
                }
                switch (parkInfo[0])
                {
                    case "register":
                        if (!parkingSlots.ContainsKey(username))
                        {
                            parkingSlots.Add(username, plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number " +
                                $"{plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!parkingSlots.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            parkingSlots.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var kvp in parkingSlots)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}

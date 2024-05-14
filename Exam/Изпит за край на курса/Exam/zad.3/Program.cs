using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int dislikedMeals = 0;
            string command = Console.ReadLine();
            while (command!="Stop")
            {
                string[] commandInfo = command.Split('-');
                string commandName = commandInfo[0];
                string guestName = commandInfo[1];
                string meal = commandInfo[2];
                switch (commandName)
                {
                    case"Like":
                        if (!guests.ContainsKey(guestName))
                        {
                            guests.Add(guestName, new List<string>());
                            if (!guests[guestName].Contains(meal))
                            {
                                guests[guestName].Add(meal);
                            }
                        }
                        else
                        {
                            if (!guests[guestName].Contains(meal))
                            {
                                guests[guestName].Add(meal);
                            }
                        }
                        break;
                    case "Dislike":
                        if (guests.ContainsKey(guestName))
                        {
                            if (guests[guestName].Contains(meal))
                            {
                                guests[guestName].Remove(meal);
                                dislikedMeals++;
                                Console.WriteLine($"{guestName} doesn't like the {meal}.");
                            }
                            else
                            {
                                Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} is not at the party.");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (var kvp in guests)
            {
                Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
            }
            Console.WriteLine($"Unliked meals: {dislikedMeals}");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegEx_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //(.\d+){0,1}
            string pattern = @"^>>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+){0,1})!(?<quantity>\d+)$";
            string input = Console.ReadLine();
            List<string> furniture = new List<string>();
            string name = string.Empty;
            double price = 0;
            int quantity = 0;
            double total = 0;
            while (input!="Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    name = match.Groups["name"].Value;
                    price = double.Parse(match.Groups["price"].Value);
                    quantity = int.Parse(match.Groups["quantity"].Value);
                    total += price * quantity;
                    furniture.Add(name);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[^\%\.\|\$]*?\%(?<name>[A-Z][a-z]+)\%[^\%\.\|\$]*?\<(?<product>\w+)\>[^\%\.\|\$]*?\|(?<count>\d+)\|[^\%\.\|\$]*?(?<price>\d+(\.\d*)?)\$[^\%\.\|\$]*?$";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            double total = 0;
            while (input!="end of shift")
            {
                Match match = regex.Match(input);
                double perPerson = 0;
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product= match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    perPerson = count * price;
                    Console.WriteLine($"{name}: {product} - {perPerson:f2}");
                    total += perPerson;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
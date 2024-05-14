using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> raceInfo = new Dictionary<string, int>();
            string first = @"[A-Za-z]";
            string second = @"[0-9]";
            List<string> names = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            foreach (var item in names)
            {
                if (!raceInfo.ContainsKey(item))
                {
                    raceInfo.Add(item, 0);
                }
            }
            while (input!="end of race")
            {
                Regex regex = new Regex(first);
                string name = string.Empty;             
                MatchCollection matchCollection = regex.Matches(input);
                foreach (Match item in matchCollection)
                {
                    name += item.Value;
                }
                Regex regex1 = new Regex(second);
                int distance = 0;
                MatchCollection matchCollection1 = regex1.Matches(input);
                if (raceInfo.ContainsKey(name))
                {
                    foreach (Match item in matchCollection1)
                    {
                        distance += int.Parse(item.Value);
                    }
                    raceInfo[name] += distance;
                }
                input = Console.ReadLine();
            }
            raceInfo = raceInfo.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            int counter = 1;
            foreach (var item in raceInfo)
            {
                if (counter==1)
                {
                    Console.WriteLine($"1st place: {string.Join("", item.Key)}");
                }
                else if (counter==2)
                {
                    Console.WriteLine($"2nd place: {string.Join("", item.Key)}");
                }
                else if (counter==3)
                {
                    Console.WriteLine($"3rd place: {string.Join("", item.Key)}");
                }
                else
                {
                    break;
                }
                counter++;
            }
        }
    }
}

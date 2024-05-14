using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] courseInfo = input.Split(" : ");
                string course = courseInfo[0];
                string name = courseInfo[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add("-- " + name);
                }
                else
                {
                    courses[course].Add("-- " + name);
                }
                input = Console.ReadLine();
            }
            foreach (var kvp in courses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                Console.WriteLine($"{string.Join(Environment.NewLine ,kvp.Value)}");
                //foreach (var item in kvp.Value)
                //{
                //    Console.WriteLine($"-- {item}");
                //}
            }
        }
    }
}

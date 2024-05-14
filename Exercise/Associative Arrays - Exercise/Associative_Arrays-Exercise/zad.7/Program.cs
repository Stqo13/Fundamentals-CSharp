using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (input != "End")
            {
                string[] companyInfo = input.Split(" -> ");
                string company = companyInfo[0];
                string id = companyInfo[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add("-- " + id);
                }
                else if (!companies[company].Contains("-- " + id))
                {
                    companies[company].Add("-- " + id);
                }
                input = Console.ReadLine();
            }    
            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine($"{string.Join(Environment.NewLine, kvp.Value)}");
            }
        }
    }
}

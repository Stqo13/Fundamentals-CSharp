using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+\b359(\s|\-)2\1\d{3}\1\d{4}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            string[] result = matches.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}

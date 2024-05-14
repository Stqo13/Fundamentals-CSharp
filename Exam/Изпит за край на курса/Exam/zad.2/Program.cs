using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1\:\s\[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine().Trim();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    string tag = match.Groups["tag"].Value;
                    int first = int.Parse(match.Groups["first"].Value);
                    int second = int.Parse(match.Groups["second"].Value);
                    int third = int.Parse(match.Groups["third"].Value);
                    string decodedMessage = $"{(char)first}{(char)second}{(char)third}";
                    sb.Append(decodedMessage);
                    //char asciiCode1 = (char)first;
                    //sb.Append(asciiCode1);
                    //char asciiCode2 = (char)second;
                    //sb.Append(asciiCode2);
                    //char asciiCode3 = (char)third;
                    //sb.Append(asciiCode3);
                    Console.WriteLine($"{tag}: {sb}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}

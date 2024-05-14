using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^[^\@\-\!\:\>]*?\@(?<planet>[A-Z][a-z]+)[^\@\-\!\:\>]*?\:(?<population>\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>(?<soliders>\d+)[^\@\-\!\:\>]+?$";
            Regex regex = new Regex(pattern);
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string encrypted = Console.ReadLine();
                string decrypted = DecryptedMessage(encrypted);
                Match match = regex.Match(decrypted);
                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    char attackType = char.Parse(match.Groups["attackType"].Value);
                    if (attackType=='A')
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackType=='D')
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }
            attackedPlanets.Sort();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var item in attackedPlanets)
            {
                if (attackedPlanets.Count>0)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            destroyedPlanets.Sort();
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets)
            {
                if (destroyedPlanets.Count > 0)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
        static string DecryptedMessage(string encrypted)
        {
            StringBuilder sb = new StringBuilder();
            int decryptCount = DecryptCount(encrypted);
            foreach (char ch in encrypted)
            {
                sb.Append((char)(ch-decryptCount));
            }
            return sb.ToString();
        }
        static int DecryptCount(string encrypted)
        {
            int decryptCount = 0;
            foreach (char ch in encrypted.ToLower())
            {
                if (ch=='s' || ch=='t' || ch=='a' || ch=='r')
                {
                    decryptCount ++;
                }
            }
            return decryptCount;
        }
    }
}

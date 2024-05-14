using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> files = new Dictionary<string, string>();
            string input = Console.ReadLine();
            string[] fileInfo = input.Split('\\');
            string nameAndExtension = fileInfo[fileInfo.Length-1];
            int start = 0;
            for (int i = 0; i < nameAndExtension.Length; i++)
            {
                if (!char.IsLetter(nameAndExtension[i]))
                {
                   start = nameAndExtension.IndexOf(nameAndExtension[i]);
                }
            }            
            string name = nameAndExtension.Substring(0, start);
            string extension = nameAndExtension.Substring(start+1);
            files.Add("File name: ", name);
            files.Add("File extension: ", extension);
            foreach (var kvp in files)
            {
                Console.WriteLine($"{kvp.Key}{kvp.Value}");
            }
        }
    }
}

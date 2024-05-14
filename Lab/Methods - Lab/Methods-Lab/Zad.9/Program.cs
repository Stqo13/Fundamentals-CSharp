using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            GetMax(type);
        }
        static void GetMax(string type)
        {
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    if (first>second)
                    {
                        Console.WriteLine(first);
                    }
                    else
                    {
                        Console.WriteLine(second);
                    }
                    break;
                case "char":
                    char ch = char.Parse(Console.ReadLine());
                    char ch1 = char.Parse(Console.ReadLine());
                    if (ch>ch1)
                    {
                        Console.WriteLine(ch);
                    }
                    else
                    {
                        Console.WriteLine(ch1);
                    }
                    break;
                case "string":
                    string text = Console.ReadLine();
                    string text1 = Console.ReadLine();
                    int result = text.CompareTo(text1);
                    if (result==0)
                    {
                        Console.WriteLine(text);
                    }
                    else if (result>0)
                    {
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine(text1);
                    }
                    break;
            }
        }
    }
}

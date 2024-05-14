using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._9_Type_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    int intResult = GetMax(first, second);
                    Console.WriteLine(intResult);
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    char charResult = GetMax(ch1, ch2);
                    Console.WriteLine(charResult);
                    break;
                case "string":
                    string text1 = Console.ReadLine();
                    string text2 = Console.ReadLine();
                    string stringResult = GetMax(text1, text2);
                    Console.WriteLine(stringResult);
                    break;
            }
        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char ch1, char ch2)
        {
            if (ch1 > ch2)
            {
                return ch1;
            }
            else
            {
                return ch2;
            }
        }
        static string GetMax(string text1, string text2)
        {
            int comparison = text1.CompareTo(text2);
            if (comparison == 0)
            {
                return text1;
            }
            else if (comparison > 0)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}

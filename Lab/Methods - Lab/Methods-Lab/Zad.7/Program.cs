using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Parameters(text, n);
            */
            string text1 = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            string result = Parameters1(text1, n1);
            Console.Write(result);
        }
        static string Parameters1(string text, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;
        }
        /*
        static void Parameters(string text, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(text);
            }
        }
        */

    }
}

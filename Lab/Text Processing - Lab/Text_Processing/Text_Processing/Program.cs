using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="end")
            {
                char[] charArr = input.ToCharArray();
                Array.Reverse(charArr);
                string reversed = new string(charArr);
                Console.WriteLine($"{input} = {reversed}");
                input = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PalindromChecker(number);

        }
        static void PalindromChecker(string number)
        {
            while (number != "END")
            {
                char[] stringArray = number.ToCharArray();
                Array.Reverse(stringArray);
                string reversedStr = new string(stringArray);
                if (number == "END")
                {
                    return;
                }
                else if (number == reversedStr)
                {
                    Console.WriteLine("true");
                }
                else if (number != reversedStr && number != "END")
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
        }
    }
}

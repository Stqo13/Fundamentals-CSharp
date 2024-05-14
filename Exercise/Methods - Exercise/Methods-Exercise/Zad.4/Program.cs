using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool validLength = Containment(password);
            bool validChars = CheckForChar(password);
            bool validNummberOfDigits = NumberContainment(password);
            if (!validLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!validChars)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!validNummberOfDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (validLength && validChars && validNummberOfDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool Containment(string pasword)
        {
            bool isValid = pasword.Length >= 6 && pasword.Length <= 10;
            return isValid;
        }
        static bool CheckForChar(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool NumberContainment(string password)
        {
            int digitCount = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            } 
                return digitCount>=2;
        }
    }
}

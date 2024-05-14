using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder cipher = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            letter += (char)3;
            cipher.Append(letter);
        }
        Console.WriteLine(cipher);
    }
}

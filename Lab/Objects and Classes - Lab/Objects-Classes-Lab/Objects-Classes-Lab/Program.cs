using System;
using System.Linq;
using System.Collections.Generic;

namespace Objects_Classes_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random random = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int randomIndex = random.Next(0, text.Length);
                string current = text[i];
                string next = text[randomIndex];
                text[randomIndex] = current;
                text[i] = next;
            }
            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}

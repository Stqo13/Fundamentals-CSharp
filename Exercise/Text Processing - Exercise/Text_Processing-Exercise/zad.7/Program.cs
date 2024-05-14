using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToList();
            int leftover = 0;
            for (int i = 0; i < input.Count; i++)
            {
                int strength = 0;
                if (input[i]=='>')
                {
                    strength = int.Parse(input[i + 1].ToString()) + leftover;
                    leftover = 0;
                } 
                if (strength==1)
                {
                    input.RemoveAt(i + 1);
                }
                else if(strength>1)
                {
                    for (int j = 0; j < strength; j++)
                    {
                        if (input[i + 1] != '>')
                        {
                            if (strength<=input.Count)
                            {
                                input.RemoveAt(i + 1);
                            }
                        }
                    }
                    leftover = strength - 1;
                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}

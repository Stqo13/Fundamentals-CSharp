using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            int leftover = 0;
            if (first=="0" || second==0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = first.Length - 1; i >= 0; i--)
            {
                int current = int.Parse(first[i].ToString());
                int product = current * second +leftover;
                int result = product % 10;
                leftover = product / 10;
                sb.Insert(0, result);
            }
            if (leftover>0)
            {
                sb.Insert(0, leftover);
            }
            Console.WriteLine(sb);
        }
    }
}

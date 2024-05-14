using System;
using System.Linq;
using System.Collections.Generic;

namespace Text_Processing_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validNames = new List<string>();
            foreach (var name in usernames)
            {
                bool flag = false;
                if (name.Length >= 3 && name.Length <= 16)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsLetterOrDigit(name[i]) || name.Contains("-") || name.Contains("_"))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    validNames.Add(name);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validNames));
        }
    }
}

using System;

namespace Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelsCount = VowelsCount(text);
            Console.WriteLine(vowelsCount);
        }
        static int VowelsCount(string text)
        {
            int vowelsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a' || text[i]=='e' || text[i]=='o' || text[i]=='u' || text[i]=='i'
                    || text[i] == 'A' || text[i] == 'E' || text[i] == 'O' || text[i] == 'U' || text[i] == 'I')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}

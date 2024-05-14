using System;

namespace DataTypes_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad1
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourth = double.Parse(Console.ReadLine());
            double add = first + second;
            double devide = add / third;
            double multiply = devide * fourth;
            Console.WriteLine(multiply);

            zad2
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while(number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
            /*
            zad3
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses=(int)Math.Ceiling((double)people/capacity);
            Console.WriteLine(courses);
            
            zad4
            int numLines = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numLines; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sum +=(int)letters;
            }
            Console.WriteLine($"The sum equals: {sum}");
            
            zad5
            int firstCh = int.Parse(Console.ReadLine());
            int lastCh = int.Parse(Console.ReadLine());
            for (int i = firstCh; i <= lastCh; i++)
            {
                char ch = (char)i;
                Console.Write(" "+ch);
            }
            
            zad6
            int numLines = int.Parse(Console.ReadLine());
            int start = 97;
            int end = start + numLines;
            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    for (int k = start; k < end; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
            
            zad7
            int input = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;
                if (sum > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters;
                }
            }
            Console.WriteLine(sum);
            */

            int kegNum = int.Parse(Console.ReadLine());
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string largestModel = string.Empty;
            double maxVolume = 0;
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            for (int i = 1; i < kegNum; i++)
            {
                if (volume > maxVolume)
                {
                    largestModel = model;
                    maxVolume = volume;
                }
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > maxVolume)
                {
                    largestModel = model;
                    maxVolume = volume;
                }
            }
            Console.WriteLine(largestModel);
        }
    }
}

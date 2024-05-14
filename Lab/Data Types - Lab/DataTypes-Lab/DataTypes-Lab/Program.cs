using System;

namespace DataTypes_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad1
            double meters = double.Parse(Console.ReadLine());
            double convert = meters / 1000;
            Console.WriteLine($"{convert:f2}");
            
            zad2
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal converter = 1.31m;
            decimal dollars = pounds * converter;
            Console.WriteLine($"{dollars:f3}");
            
            zad3
            decimal numbers = decimal.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numbers; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum}");
            
            zad4
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
            
            zad5
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int num = i;
                for (int e = 0; e < i.ToString().Length; e++)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum!=5 && sum!=7 && sum!=11)
                {
                    Console.WriteLine($"{i} -> False");
                }
                else if (sum==5 || sum==7 || sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
             }   
                zad6
                string charche1 = Console.ReadLine();
                string charche2 = Console.ReadLine();
                string charche3 = Console.ReadLine();
                string reversed = charche3 + " " + charche2 + "" + charche1;
                Console.WriteLine(reversed);
                
            zad7
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{lastName}");
            
            zad8
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
            
            zad 9
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            string combination = first.ToString() + second.ToString() + third.ToString();
            Console.WriteLine(combination);
            
            zad10
            char charchance = char.Parse(Console.ReadLine());
            if (char.IsUpper(charchance))
            {
                Console.WriteLine("upper-case");
            }
            else if (char.IsLower(charchance))
            {
                Console.WriteLine("lower-case");
            }
            
            zad11
            Console.Write("Length: ");
            double Lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            double Volume = (Lenght * Width * Height) / 3;
            Console.WriteLine($"Pyramid Volume: {Volume: f2}");
            */

            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int num = i;
                for (int e = 0; e < i.ToString().Length; e++)
                {
                    sum += num % 10;
                    num /= 10;
                }
                if (sum != 5 && sum != 7 && sum != 11)
                {
                    Console.WriteLine($"{i} -> False");
                }
                else if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
            }
        }
    }
}

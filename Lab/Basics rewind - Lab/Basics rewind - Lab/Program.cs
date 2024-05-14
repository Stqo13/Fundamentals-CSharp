using System;
using System.Globalization;

namespace Basics_rewind___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            zad 1
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
            
            zad.2, 3
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }

            zad4
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine())+30;
            if (min>59)
            {
                hours++;
                min -= 60;
            }
            if (hours>23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{min:D2}");

            zad5
            double integer = double.Parse(Console.ReadLine());
            if (integer >= 13 || integer < 1)
            {
                Console.WriteLine("Error!");
            }
            switch (integer)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
            }

            zad6
            string country = Console.ReadLine();
            switch (country)
            {
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                    Console.WriteLine("Spanish");
                    break;
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

            zad 7
            string typeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            switch (typeDay)
            {
                case "Weekday":
                    if (0<=age && age<=18)
                    {
                        price += 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18<age && age<=64)
                    {
                        price += 18;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        price += 10;
                        Console.WriteLine($"{price}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price += 15;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        price += 20;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        price += 10;
                        Console.WriteLine($"{price}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price += 5;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        price += 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64<age && age<= 122)
                    {
                        price += 10;
                        Console.WriteLine($"{price}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }

            zad 8
            for (int i = 3; i <= 100; i+=3)
            {
                Console.WriteLine(i);
            }

            zad 9
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n*2; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");

            zad 10
            int num = int.Parse(Console.ReadLine());
            int product = 1;
            for (int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine($"{num} X {i} = {product}");
            }
            
            zad 10
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 1;
            if (multiplier<=10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    product = num * i;
                    Console.WriteLine($"{num} X {i} = {product}");
                }
            }
            else
            {
                product = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {product}");
            }
           
            zad 12
            int num = int.Parse(Console.ReadLine());
            bool flag = true;
            if (num%2==0)
            {
                Console.WriteLine($"The number is: {Math.Abs(num)}");
            }
            while (num%2==1)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    flag = false;
                }
                if (flag==false)
                {
                    break;
                }
            }
            */

            var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate;date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
            Console.WriteLine(holidaysCount);
        }
    }
}

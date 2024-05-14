using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_rewind___Urp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             zad 1
            int age = int.Parse(Console.ReadLine());
            if (age>=0 && age<=2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age>=66)
            {
                Console.WriteLine("elder");
            }
            
            zad 2
                int integer = int.Parse(Console.ReadLine());
                if (integer % 10 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                }
                else if (integer % 7 == 0)
                {
                Console.WriteLine("The number is divisible by 7");
                }
                else if (integer % 6 == 0)
                {
                    Console.WriteLine("The number is divisible by 6");
                }
                else if (integer % 3 == 0)
                {
                    Console.WriteLine("The number is divisible by 3");
                }
                else if (integer % 2 == 0)
                {
                    Console.WriteLine("The number is divisible by 2");
                }
                else
                {
                Console.WriteLine("Not divisible");
                }
                
            zad3
            int count = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.00;
            switch (day)
            {
                case "Friday":
                    switch (groupType)
                    {
                        case "Students":
                            price = count * 8.45;
                            if (count>=30)
                            {
                                price = price - (price * 0.15);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Business":
                            price = count * 10.90;
                            if (count >= 100)
                            {
                                price = price - (10.90 * 10);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Regular":
                            price = count * 15;
                            if (count>=10 && count<=20)
                            {
                                price = price - (price * 0.05);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                    }
                    break;

                case "Saturday":
                    switch (groupType)
                    {
                        case "Students":
                            price = count * 9.80;
                            if (count >= 30)
                            {
                                price = price - (price * 0.15);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Business":
                            price = count * 15.60;
                            if (count >= 100)
                            {
                                price = price - (10.90 * 10);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Regular":
                            price = count * 20;
                            if (count >= 10 && count <= 20)
                            {
                                price = price - (price * 0.05);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                    }
                    break;

                case "Sunday":
                    switch (groupType)
                    {
                        case "Students":
                            price = count * 10.46;
                            if (count >= 30)
                            {
                                price = price - (price * 0.15);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Business":
                            price = count * 16;
                            if (count >= 100)
                            {
                                price = price - (10.90 * 10);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                        case "Regular":
                            price = count * 22.50;
                            if (count >= 10 && count <= 20)
                            {
                                price = price - (price * 0.05);
                            }
                            Console.WriteLine($"Total price: {price:f2}");
                            break;
                    }
                    break;
            }
            
            zad 4
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            
            zad5
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length-1; i >= 0; i--)
            {
                char current = username[i];
                password += current;
            }
            int tryCount = 1;
            string tries;
            while ((tries = Console.ReadLine()) !=password)
            {
                if (tryCount>=4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                tryCount++;
            }
            if (tryCount<4 && tries==password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
            zad 6
            int number = int.Parse(Console.ReadLine());
            int numCopy = number;
            int factorialSum = 0;
            while (numCopy>0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                int factorial = 1;
                for (int i = 2; i <= lastDigit ; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (factorialSum==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
            zad 7
            string coins = Console.ReadLine();
            double coinsSum = 0;
            while (coins!="Start")
            {
                switch (coins)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2":
                        coinsSum += double.Parse(coins);
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }
                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            double productPrice = 0;
            while (product!="End")
            {
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (coinsSum >= productPrice && coinsSum > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    coinsSum = coinsSum - productPrice;
                    productPrice = 0;
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    productPrice = 0;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinsSum:F2}");
            
            zad 8
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            
            zad 9
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double saberCount = Math.Ceiling(students + (0.1 * students));
            int beltCounter = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i%6==0)
                {
                    beltCounter++;
                }
            }
            double totalPrice = (saberPrice*saberCount) + (robePrice*students) + (beltPrice*students-(beltCounter*beltPrice));
            if (money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice-money:f2}lv more.");
            }
            
            zad 10
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int hTrash = 0;
            int mTrash = 0;
            int kTrash = 0;
            int dTrash = 0;
            double rageExpenses = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    hTrash++;
                }
                if (i%3==0)
                {
                    mTrash++;
                }
                if (i%2==0 && i%3==0)
                {
                    kTrash++;
                }
                if (i%12==0)
                {
                    dTrash++;
                }
            }
            rageExpenses = (hTrash*headsetPrice) + (mTrash*mousePrice) + (kTrash*keyboardPrice) + (dTrash*displayPrice);
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
            */

            int orders = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;
            for (int i = 1; i <=orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                price = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                total += price;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}

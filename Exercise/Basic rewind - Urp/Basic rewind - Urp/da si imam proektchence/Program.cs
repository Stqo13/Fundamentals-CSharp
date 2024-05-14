using System;

namespace da_si_imam_proektchence
{
    class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double coinsSum = 0;
            while (coins != "Start")
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
            while (product != "End")
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
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();
            while (input!="buy")
            {
                string[] orderInfo = input.Split();
                string product = orderInfo[0];
                double price = double.Parse(orderInfo[1]);
                int ammount = int.Parse(orderInfo[2]);
                if (!orders.ContainsKey(product))
                {
                    orders.Add(product, new List<double>());
                    orders[product].Add(price);
                    orders[product].Add(ammount);
                }
                else
                {
                    orders[product][0] = price;
                    orders[product][1] += ammount;

                }
                input = Console.ReadLine();
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }
        }
    }
}

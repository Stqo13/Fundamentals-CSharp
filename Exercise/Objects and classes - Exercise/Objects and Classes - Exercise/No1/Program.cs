using System;
using System.Collections.Generic;
using System.Linq;
namespace No1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use thatproduct.",
                "Best product of its category.",
                "Exceptional product.",
                "I can'tlive without this product."
            };
            List<string> events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makesmiracles. I am happy of the results!",
                "I cannot believe but now I feelawesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n-1; i++)
            {
                Random r = new Random();
                
                Console.WriteLine($"{phrases[r.Next(0,phrases.Count)]} {events[r.Next(0, events.Count)]} {authors[r.Next(0, authors.Count)]} – {cities[r.Next(0, cities.Count)]}.");
            }
        }
    }
}

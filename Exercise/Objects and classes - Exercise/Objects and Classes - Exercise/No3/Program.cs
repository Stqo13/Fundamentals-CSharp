using System;
using System.Collections.Generic;
using System.Linq;
namespace No2
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
       
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for (int i = 0; i <= n - 1; i++)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();
                Article article = new Article();
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];
                listOfArticles.Add(article);
            }
            foreach(var item in listOfArticles)
            {
                Console.WriteLine(item.ToString());
            }
            
           
           
            
           
        }
    }
}

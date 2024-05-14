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
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString() 
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            Article article = new Article();
            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n - 1; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();
                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}

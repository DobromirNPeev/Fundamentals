using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title,string content,string author)
        {
            Title = title;
            Content = content;
            Author = author;
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
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] article = Console.ReadLine().Split(", ");
                string title = article[0];
                string content = article[1];
                string author = article[2];
                Article currArticle = new Article(title, content, author);
                articles.Add(currArticle);
            }
            string input = Console.ReadLine();
            if (input == "title")
            {
                articles = articles.OrderBy(x=>x.Title).ToList();
            }
            else if (input == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (input == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            foreach (var item in articles)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

using System;

namespace _02._Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Edit(string content)
        {
            Content = content;
            return Content;
        }
        public string ChangeAuthor(string author)
        {
            Author = author;
            return Author;
        }
        public string Rename(string title)
        {
            Title = title;
            return Title;
        }
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
            string[] article = Console.ReadLine().Split(", ");
            string title = article[0];
            string content = article[1];
            string author = article[2];
            Article theArticle = new Article(title,content,author);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                string theCommand = command[0];
                string replacement = command[1];
                if (theCommand == "Edit")
                {
                    theArticle.Edit(replacement);
                }
                else if (theCommand == "ChangeAuthor")
                {
                    theArticle.ChangeAuthor(replacement);
                }
                else if (theCommand == "Rename")
                {
                    theArticle.Rename(replacement);
                }
            }
            Console.WriteLine(theArticle.ToString());
        }
    }
}

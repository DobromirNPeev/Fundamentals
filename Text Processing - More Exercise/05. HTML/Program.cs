using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();
            string currComment = string.Empty;
            while((currComment=Console.ReadLine())!= "end of comments")
            {
                comments.Add(currComment);
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            foreach (var item in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {item}");
                Console.WriteLine("</div>");
            }
        }
    }
}

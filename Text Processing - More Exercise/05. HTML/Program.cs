using System;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            Console.WriteLine(@$"<h1>
    {article}
</h1>");
            string content = Console.ReadLine();
            Console.WriteLine(@$"<article>
    {content}
</article>");
            string comment = Console.ReadLine();
            while(comment != "end of comments")
            {
                Console.WriteLine(@$"<div>
    {comment}
</div>");
                comment = Console.ReadLine();
            }

        }
    }
}
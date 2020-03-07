using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine().Split("&").ToList();

            string command = "";
            command = Console.ReadLine();
            while (command != "Done")
            {
                string[] inputCommands = command.Split(" | ").ToArray();

                if(inputCommands[0] == "Add Book")
                {
                    if (!books.Contains(inputCommands[1])) books.Insert(0, inputCommands[1]);
                }
                else if (inputCommands[0] == "Take Book")
                {
                    if (books.Contains(inputCommands[1])) books.Remove(inputCommands[1]);
                }
                else if (inputCommands[0] == "Swap Books")
                {
                    if (books.Contains(inputCommands[1]) && books.Contains(inputCommands[2]))
                    {
                        int indexBook1 = books.IndexOf(inputCommands[1]);
                        int indexBook2 = books.IndexOf(inputCommands[2]);
                        string testTitle = books[indexBook1];
                        books[indexBook1] = books[indexBook2];
                        books[indexBook2] = testTitle;
                    }
                }
                else if (inputCommands[0] == "Insert Book")
                {
                    books.Add(inputCommands[1]);
                }
                else if (inputCommands[0] == "Check Book")
                {
                    if(int.Parse(inputCommands[1]) >=0 && int.Parse(inputCommands[1]) < books.Count)
                    {
                        Console.WriteLine(books[int.Parse(inputCommands[1])]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",books));
        }
    }
}
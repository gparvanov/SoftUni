using System;
using System.Text.RegularExpressions;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i].Length <= 16)
                {
                    if (Regex.IsMatch(words[i], @"^[a-zA-Z0-9\-_]*?$")) Console.WriteLine(words[i]);
                }
            }            
        }
    }
}

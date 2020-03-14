using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char prevChar = default;
            string output = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] != prevChar)
                {
                    output += text[i];
                    prevChar = text[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
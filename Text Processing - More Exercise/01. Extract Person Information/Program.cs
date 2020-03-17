using System;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                int age = 0;

                int nameStart = text.IndexOf("@");
                int nameEnd = text.IndexOf("|");
                int ageStart = text.IndexOf("#");
                int ageEnd = text.IndexOf("*");

                name = text.Substring(nameStart +1, nameEnd - nameStart -1);
                age = int.Parse(text.Substring(ageStart + 1, ageEnd - ageStart - 1));

                Console.WriteLine($"{ name} is { age } years old.");
            }
        }
    }
}

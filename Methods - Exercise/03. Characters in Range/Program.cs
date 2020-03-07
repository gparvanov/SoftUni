using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());

            PrintSymbolsFromTo(startLetter, endLetter);
        }

        static void PrintSymbolsFromTo(char a, char b)
        {
            int min = Math.Min(a, b) + 1;
            int max = Math.Max(a, b);
            for (int i = min; i < max; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}

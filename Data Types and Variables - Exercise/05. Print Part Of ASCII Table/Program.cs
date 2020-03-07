using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = (char)int.Parse(Console.ReadLine());
            char endSymbol = (char)int.Parse(Console.ReadLine());

            for (char i = startSymbol; i <= endSymbol; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}

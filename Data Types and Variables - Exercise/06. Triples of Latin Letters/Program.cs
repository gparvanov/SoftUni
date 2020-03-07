using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequentLetters = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + sequentLetters; i++)
            {
                for (char j = 'a'; j < 'a' + sequentLetters; j++)
                {
                    for (char k = 'a'; k < 'a' + sequentLetters; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}

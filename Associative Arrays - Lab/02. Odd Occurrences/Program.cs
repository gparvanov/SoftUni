using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWord = word.ToLower(); 
                if (!dict.ContainsKey(currentWord))
                {
                    dict[currentWord] = 0;
                }
                dict[currentWord]++;
            }
            foreach (var item in dict)
            {
                if(item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

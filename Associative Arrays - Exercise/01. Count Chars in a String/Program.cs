using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var dict = new Dictionary<char, int>();
            foreach (var item in text)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 0;
                }
                dict[item]++;
            }
            foreach (var item in dict)
            {
                if (item.Key != ' ')
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }
    }
}
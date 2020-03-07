using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var dict = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (dict.ContainsKey(numbers[i]))
                {
                    dict[numbers[i]]++;
                }
                else
                {
                    dict.Add(numbers[i], 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while ( input != "end")
            {
                string[] data = input.Split(" : ");
                if (!courses.ContainsKey(data[0]))
                {
                    courses[data[0]] = new List<string>();
                }
                courses[data[0]].Add(data[1]);
                input = Console.ReadLine();
            }
            var result = courses
                .OrderByDescending(x => x.Value.Count);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                item.Value.Sort();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
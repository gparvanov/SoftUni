using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();
            string command = "";
            command = Console.ReadLine();
            while (command != "End")
            {
                string[] data = command.Split(" -> ");
                if (!companies.ContainsKey(data[0]))
                {
                    companies[data[0]] = new List<string>();
                    companies[data[0]].Add(data[1]);
                }
                else if(!companies[data[0]].Contains(data[1]))
                {
                    companies[data[0]].Add(data[1]);
                }
                command = Console.ReadLine();
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
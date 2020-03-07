using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            var dict = new Dictionary<string, int>();
            while (command != "stop")
            {
                command = Console.ReadLine();
                if (command == "stop") break;
                int value = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(command))
                {
                    dict[command] = 0;
                }
                dict[command] += value;                
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
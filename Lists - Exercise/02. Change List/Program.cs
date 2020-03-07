using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();            
            string command = "";
            command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "end")
                {
                    Console.WriteLine(string.Join(' ', list));
                    return;
                }
                string[] input = command.Split().ToArray();
                if (input[0] == "Delete")
                {
                    while (list.Contains(int.Parse(input[1])))
                    {
                        list.Remove(int.Parse(input[1]));
                    }
                }
                else if (input[0] == "Insert") list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
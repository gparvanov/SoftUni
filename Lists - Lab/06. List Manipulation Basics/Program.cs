using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            while(command != "end")
            {
                if(command == "end") Console.WriteLine(string.Join(' ',list));
                
                string[] input = command.Split().ToArray();
                if (input[0] == "Add") list.Add(int.Parse(input[1]));
                else if (input[0] == "Remove") list.Remove(int.Parse(input[1]));
                else if (input[0] == "RemoveAt") list.RemoveAt(int.Parse(input[1]));
                else if (input[0] == "Insert") list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}

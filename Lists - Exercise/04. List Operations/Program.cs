using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "End") break;
                string[] input = command.Split().ToArray();
                if (input[0] == "Add") numbers.Add(int.Parse(input[1]));
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) >= numbers.Count || int.Parse(input[2]) <0 ) Console.WriteLine("Invalid index");
                    else numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) >= numbers.Count || int.Parse(input[1]) < 0 ) Console.WriteLine("Invalid index");
                    else numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Shift") ShiftList(numbers, input[1], int.Parse(input[2]));
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
        static void ShiftList(List<int> l, string direction,int count)
        {
            if(direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int firstElement = l[0];
                    l.Add(firstElement);
                    l.RemoveAt(0);
                }
            }
            else if ( direction == "right")
            {
                for (int i = 0; i < count; i++)
                {
                    int lastElement = l[l.Count-1];
                    l.Insert(0,lastElement);
                    l.RemoveAt(l.Count-1);
                }
            }
        }
    }
}

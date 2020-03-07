using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            bool listModified = false;
            while (command != "end")
            {
                if (command == "end") 
                {
                    if (listModified) Console.WriteLine(string.Join(' ', list));
                    return;
                }
                string[] input = command.Split().ToArray();
                
                if (input[0] == "Add")
                {
                    listModified = true;
                    list.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    listModified = true;
                    list.Remove(int.Parse(input[1]));
                }
                else if (input[0] == "RemoveAt")
                {
                    listModified = true;
                    list.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert") 
                {
                    listModified = true;
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                else if (input[0] == "Contains")
                {
                    bool contains = list.Contains(int.Parse(input[1]));
                    if (contains) Console.WriteLine("Yes");
                    else Console.WriteLine("No such number");
                }
                else if (input[0] == "PrintEven") PrintAllEven(list);
                else if (input[0] == "PrintOdd") PrintAllOdd(list);
                else if (input[0] == "GetSum") PrintListSumOfElements(list);
                else if (input[0] == "Filter") PrintFilteredList(list, input[1], int.Parse(input[2]));
                command = Console.ReadLine();
            }
            if(listModified) Console.WriteLine(string.Join(' ', list));
        }
        static void PrintAllEven(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] % 2 == 0) Console.Write(l[i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintAllOdd(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] % 2 != 0) Console.Write(l[i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintListSumOfElements(List<int> l)
        {
            int sum = 0;
            for (int i = 0; i < l.Count; i++)
            {
                sum += l[i];
            }
            Console.WriteLine(sum);
        }
        static void PrintFilteredList(List<int> l, string condition, int value)
        {
            for (int i = 0; i < l.Count; i++)
            {
                if (condition == ">" && l[i] > value) Console.Write(l[i] + " ");
                else if (condition == ">=" && l[i] >= value) Console.Write(l[i] + " ");
                else if (condition == "<" && l[i] < value) Console.Write(l[i] + " ");
                else if (condition == "<=" && l[i] <= value) Console.Write(l[i] + " ");
            }
            Console.WriteLine();            
        }
    }
}
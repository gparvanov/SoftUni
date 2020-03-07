using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            while (command != "End")
            {
                string[] input = command.Split();
                if (input[0] == "Complete")
                {
                    if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < tasks.Count) tasks[int.Parse(input[1])] = 0;
                }
                else if (input[0] == "Change")
                {
                    if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < tasks.Count) tasks[int.Parse(input[1])] = int.Parse(input[2]);
                }
                else if (input[0] == "Drop")
                {
                    if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < tasks.Count) tasks[int.Parse(input[1])] = -1;
                }
                else if (input[0] == "Count" && input[1] == "Completed")
                {
                    List<int> tempList = tasks.FindAll(s => s == 0);
                    Console.WriteLine(tempList.Count);
                }
                else if (input[0] == "Count" && input[1] == "Incomplete")
                {
                    List<int> tempList = tasks.FindAll(s => s > 0);
                    Console.WriteLine(tempList.Count);
                }
                else if (input[0] == "Count" && input[1] == "Dropped")
                {
                    List<int> tempList = tasks.FindAll(s => s < 0);
                    Console.WriteLine(tempList.Count);
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] > 0) Console.Write($"{tasks[i]} ");
            }
            Console.WriteLine();
        }
    }
}
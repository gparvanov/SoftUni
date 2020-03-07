using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();

            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandLine = command.Split(" - ").ToArray();

                if(commandLine[0] == "Collect")
                {
                    if (!items.Contains(commandLine[1])) items.Add(commandLine[1]);
                }
                else if ( commandLine[0] == "Drop")
                {
                    if (items.Contains(commandLine[1])) items.Remove(commandLine[1]);
                }
                else if ( commandLine[0] == "Combine Items")
                {
                    string[] itemsTwo = commandLine[1].Split(":").ToArray();
                    string oldItem = itemsTwo[0];
                    string newItem = itemsTwo[1];
                    if(items.Contains(oldItem) && items.IndexOf(oldItem) != items.Count - 1)
                    {
                        items.Insert(items.IndexOf(oldItem) + 1, newItem);
                    }
                    else if (items.Contains(oldItem) && items.IndexOf(oldItem) == items.Count - 1)
                    {
                        items.Add(newItem);
                    }
                }
                else if (commandLine[0] == "Renew")
                {
                    if (items.Contains(commandLine[1]))
                    {
                        items.Remove(commandLine[1]);
                        items.Add(commandLine[1]);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
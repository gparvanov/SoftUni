using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine().Split().ToList();
            string command = "";
            command =Console.ReadLine();
            while (command != "End")
            {
                string[] inputData = command.Split();
                if(inputData[0] == "Add")
                {
                    if (!contacts.Contains(inputData[1])) contacts.Add(inputData[1]);
                    else
                    {
                        if(int.Parse(inputData[2]) >= 0 && int.Parse(inputData[2]) <=contacts.Count - 1)
                        {
                            contacts.Insert(int.Parse(inputData[2]), inputData[1]);
                        }
                    }
                }
                else if (inputData[0] == "Remove")
                {
                    if (int.Parse(inputData[1]) >= 0 && int.Parse(inputData[1]) <= contacts.Count - 1) contacts.RemoveAt(int.Parse(inputData[1]));
                }
                else if (inputData[0] == "Export")
                {
                    int start = int.Parse(inputData[1]);
                    if (start >= contacts.Count - 1) start = 0;
                    int count = int.Parse(inputData[2]);
                    int printed = 0;
                    if (count >= contacts.Count) count = contacts.Count;
                    for (int i = start; i < contacts.Count; i++)
                    {
                        printed++;
                        Console.Write($"{contacts[i]} ");
                        if (printed >= count) break;
                    }
                    Console.WriteLine();
                }
                else if (inputData[0] == "Print")
                {
                    if(inputData[1] == "Normal") Console.WriteLine("Contacts: " + string.Join(" ", contacts));
                    else if (inputData[1] =="Reversed")
                    {
                        contacts.Reverse();
                        Console.WriteLine("Contacts: " +  string.Join(" ", contacts));
                    }
                    return;
                }
                command = Console.ReadLine();                
            }
        }
    }
}
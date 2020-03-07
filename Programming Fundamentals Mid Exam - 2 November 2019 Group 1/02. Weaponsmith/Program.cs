using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("|").ToList();
            string command = "";
            command = Console.ReadLine();
            while (command != "Done")
            {
                string[] inputCommands = command.Split();
                if(inputCommands[0] == "Move" && inputCommands[1] == "Left")
                {
                    if(int.Parse(inputCommands[2])>0 && int.Parse(inputCommands[2]) < list.Count)
                    {
                        string tempValue = list[int.Parse(inputCommands[2])];
                        list.RemoveAt(int.Parse(inputCommands[2]));
                        list.Insert(int.Parse(inputCommands[2]) - 1, tempValue);
                    }
                }
                else if (inputCommands[0] == "Move" && inputCommands[1] == "Right")
                {
                    if (int.Parse(inputCommands[2]) >= 0 && int.Parse(inputCommands[2]) < list.Count -1)
                    {
                        string tempValue = list[int.Parse(inputCommands[2])];
                        list.RemoveAt(int.Parse(inputCommands[2]));
                        list.Insert(int.Parse(inputCommands[2]) + 1, tempValue);
                    }
                }
                else if (inputCommands[0] == "Check" && inputCommands[1] == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 == 0) Console.Write($"{list[i]} ");
                    }
                    Console.WriteLine();
                }
                else if (inputCommands[0] == "Check" && inputCommands[1] == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i % 2 != 0) Console.Write($"{list[i]} ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You crafted {string.Join("",list)}!");
        }
    }
}
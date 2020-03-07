using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy_Squad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogs = Console.ReadLine().Split().ToList();
            
            string[] input = Console.ReadLine().Split();
            while (input[0] != "")
            {                
                if (input[0] == "Join") frogs.Add(input[1]);
                else if (input[0] == "Jump")
                {
                    if (int.Parse(input[2]) >= 0 && int.Parse(input[2]) < frogs.Count) frogs.Insert(int.Parse(input[2]),input[1]);
                }
                else if (input[0] == "Dive")
                {
                    if (int.Parse(input[1]) >= 0 && int.Parse(input[1]) < frogs.Count) frogs.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "First")
                {
                    int endIndex = 0;
                    if (int.Parse(input[1]) > frogs.Count - 1) endIndex = frogs.Count;
                    else endIndex = int.Parse(input[1]);
                    for (int i = 0; i < endIndex; i++)
                    {
                        Console.Write($"{frogs[i]} ");
                    }
                    Console.WriteLine();
                }
                else if (input[0] == "Last")
                {
                    int stopIndex = 0;
                    if (int.Parse(input[1]) > frogs.Count - 1) stopIndex = -1;
                    else stopIndex = frogs.Count - 1 - int.Parse(input[1]);
                    List<string> tempList = new List<string>();
                    for (int i = frogs.Count -1 ; i > stopIndex ; i--)
                    {
                        tempList.Add(frogs[i]);
                    }
                    tempList.Reverse();
                    Console.WriteLine(string.Join(" ",tempList));
                }
                else if (input[0] == "Print")
                {
                    if(input[1] == "Normal")
                    {
                        Console.Write("Frogs: ");
                        Console.WriteLine(string.Join(" ",frogs));
                    }
                    else
                    {
                        Console.Write("Frogs: ");
                        for (int i = frogs.Count -1 ; i >=0; i--)
                        {
                            Console.Write($"{frogs[i]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }                
                input = Console.ReadLine().Split();                
            }            
        }
    }
}
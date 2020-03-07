using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> startLoot = Console.ReadLine().Split("|").ToList();

            string command = "";
            command = Console.ReadLine();
            while (command != "Yohoho!")
            {
                string[] inputParts = command.Split();
                if(inputParts[0] == "Loot")
                {
                    List<string> newLoot = command.Split().ToList();
                    for (int i = 1; i < newLoot.Count; i++)
                    {
                        if (!startLoot.Contains(newLoot[i])) startLoot.Insert(0, newLoot[i]);
                    }
                }
                else if (inputParts[0] == "Drop")
                {
                    if(int.Parse(inputParts[1]) >=0 && int.Parse(inputParts[1])<=startLoot.Count-1)
                    {
                        string loot = startLoot[int.Parse(inputParts[1])];
                        startLoot.RemoveAt(int.Parse(inputParts[1]));
                        startLoot.Add(loot);
                    }
                }
                else if (inputParts[0] == "Steal")
                {
                    int stolen = int.Parse(inputParts[1]);
                    if (stolen >= startLoot.Count) stolen = startLoot.Count;
                    List<string> stolenLoot = new List<string>();
                    int taken = 0;
                    for (int i = startLoot.Count - 1 ; i>= 0; i--)
                    {
                        taken++;
                        string value = startLoot[i];
                        startLoot.Remove(value);
                        stolenLoot.Add(value);
                        if (taken >= stolen) break;
                    }
                    stolenLoot.Reverse();
                    Console.WriteLine(string.Join(", ",stolenLoot));
                }
                command = Console.ReadLine();
            }            
            if (startLoot.Count > 0)
            {
                int gainedTresure = 0;
                for (int i = 0; i < startLoot.Count; i++)
                {
                    gainedTresure += startLoot[i].Length;
                }
                double averageGain = gainedTresure * 1.0 / startLoot.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else Console.WriteLine("Failed treasure hunt.");            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main()
        {
            var forceSide = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            while(command != "Lumpawaroo")
            {
                if(command.Contains(" | "))
                {
                    string[] data = command.Split(" | ");
                    string side = data[0];
                    string user = data[1];
                    if (!forceSide.ContainsKey(side))
                    {
                        forceSide[side] = new List<string>();
                        forceSide[side].Add(user);
                    }
                    else if (!forceSide[side].Contains(user)) forceSide[side].Add(user);                    
                }
                else if(command.Contains(" -> "))
                {
                    string[] data = command.Split(" -> ");
                    string user = data[0];
                    string side = data[1];
                    bool found = false;
                    string foundKey = "";
                    foreach (var item in forceSide)
                    {
                        if (item.Value.Contains(user)) 
                        {
                            found = true;
                            foundKey = item.Key;
                            break;
                        }
                    }
                    if (found)
                    {
                        forceSide[foundKey].Remove(user);
                        if (!forceSide.ContainsKey(side))
                        {
                            forceSide[side] = new List<string>();
                            forceSide[side].Add(user);
                        }
                        else forceSide[side].Add(user);
                    }
                    else
                    {
                        if (!forceSide.ContainsKey(side))
                        {
                            forceSide[side] = new List<string>();
                            forceSide[side].Add(user);
                        }
                        else forceSide[side].Add(user);
                    }
                    Console.WriteLine($"{user} joins the {side} side!");
                }
                command = Console.ReadLine();
            }
            var result = forceSide
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);
            foreach (var item in result)
            {
                if (item.Value.Count > 0)
                {                    
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    //item.Value.Sort();
                    var list = item.Value.OrderBy(x => x).ToList();
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        Console.WriteLine($"! {list[i]}");
                    }
                }
            }
        }
    }
}
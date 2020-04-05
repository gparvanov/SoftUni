using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            var bandsMembers = new Dictionary<string, List<string>>();
            var bandsTime = new Dictionary<string, int>();
            int totalTime = 0;
            string command = Console.ReadLine();

            while(command != "start of concert")
            {
                string[] inputData = command.Split(";");
                if(inputData[0] == "Add")
                {
                    string name = inputData[1].Trim();
                    string[] members = inputData[2].Split(", ");
                    if (!bandsMembers.ContainsKey(name))
                    {
                        bandsMembers[name] = new List<string>();
                        foreach (var member in members)
                        {
                            bandsMembers[name].Add(member.Trim());
                        }
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if(!bandsMembers[name].Contains(member.Trim()))
                            {
                                bandsMembers[name].Add(member.Trim());
                            }
                        }
                    }
                }
                else if (inputData[0] == "Play")
                {
                    string name = inputData[1].Trim();
                    if (!bandsTime.ContainsKey(name))
                    {
                        bandsTime[name] = int.Parse(inputData[2]);
                    }
                    else bandsTime[name] += int.Parse(inputData[2]);
                    totalTime += int.Parse(inputData[2]);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {totalTime}");

            var timeResult = bandsTime.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);

            foreach (var group in timeResult)
            {                
                Console.WriteLine($"{group.Key} -> {group.Value}");
            }

            string band = Console.ReadLine();
            Console.WriteLine(band);
            var foundGroup = bandsMembers.Where(x => x.Key.Contains(band));

            foreach (var group in foundGroup)
            {
                var membersNames = group.Value;
                foreach (var member in membersNames)
                {
                    Console.WriteLine($"=> {member}");
                }                
            }
        }
    }
}
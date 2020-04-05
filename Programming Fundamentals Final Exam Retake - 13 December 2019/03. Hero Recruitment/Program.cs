using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] inputData = command.Split(" ");
                if(inputData[0] == "Enroll")
                {
                    if (!heroes.ContainsKey(inputData[1]))
                    {
                        heroes[inputData[1]] = new List<string>();                        
                    }
                    else Console.WriteLine($"{inputData[1]} is already enrolled.");
                }
                else if ( inputData[0] == "Learn")
                {
                    if (heroes.ContainsKey(inputData[1]))
                    {
                        if (!heroes[inputData[1]].Contains(inputData[2]))
                        {
                            heroes[inputData[1]].Add(inputData[2]);
                        }
                        else Console.WriteLine($"{inputData[1]} has already learnt {inputData[2]}.");
                        
                    }
                    else Console.WriteLine($"{inputData[1]} doesn't exist.");
                }
                else if ( inputData[0] == "Unlearn")
                {
                    if (heroes.ContainsKey(inputData[1]))
                    {
                        if (heroes[inputData[1]].Contains(inputData[2]))
                        {
                            heroes[inputData[1]].Remove(inputData[2]);
                        }
                        else Console.WriteLine($"{inputData[1]} doesn't know {inputData[2]}.");

                    }
                    else Console.WriteLine($"{inputData[1]} doesn't exist.");
                }
                command = Console.ReadLine();
            }
            var result = heroes.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);
            
            Console.WriteLine("Heroes:");
            foreach (var hero in result)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ",hero.Value)}");
            }
        }
    }
}
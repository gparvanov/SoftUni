using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while(command != "Results")
            {
                string[] inputData = command.Split(":");

                if(inputData[0] == "Add")
                {
                    string name = inputData[1];
                    int health = int.Parse(inputData[2]);
                    int energy = int.Parse(inputData[3]);

                    if (!users.ContainsKey(name))
                    {
                        users[name] = new List<int>();
                        users[name].Add(health);
                        users[name].Add(energy);
                    }
                    else users[name][0] += health;
                }
                else if ( inputData[0] == "Attack")
                {
                    string attackerName = inputData[1];
                    string defenderName = inputData[2];
                    int damage = int.Parse(inputData[3]);

                    if(users.ContainsKey(attackerName) && users.ContainsKey(defenderName))
                    {
                        users[defenderName][0] -= damage;
                        if(users[defenderName][0] <=0 )
                        {
                            users.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }
                        users[attackerName][1] -= 1;
                        if (users[attackerName][1] <= 0)
                        {
                            users.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }
                else if ( inputData[0] == "Delete")
                {
                    if (inputData[1] == "All") users = new Dictionary<string, List<int>>();
                    else if(users.ContainsKey(inputData[1])) users.Remove(inputData[1]);                    
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"People count: {users.Count}");

            var result = users.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key);

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key} - {user.Value[0]} - {user.Value[1]}");
            }
        }
    }
}
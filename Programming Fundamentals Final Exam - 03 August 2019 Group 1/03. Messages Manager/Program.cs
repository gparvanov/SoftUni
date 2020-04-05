using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<int>>();

            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] inputData = command.Split("=");
                
                if(inputData[0] == "Add")
                {
                    string username = inputData[1];
                    int sentMessages = int.Parse(inputData[2]);
                    int receivedMessages = int.Parse(inputData[3]);
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new List<int>();
                        users[username].Add(sentMessages);
                        users[username].Add(receivedMessages);
                    }
                }
                else if (inputData[0] == "Message")
                {
                    string sender = inputData[1];
                    string receiver = inputData[2];
                    if(users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender][0]++;
                        if (users[sender].Sum() >= capacity)
                        {
                            users.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        users[receiver][1]++;
                        if (users[receiver].Sum() >= capacity)
                        {
                            users.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                else if (inputData[0] == "Empty")
                {
                    if (inputData[1] == "All") users = new Dictionary<string, List<int>>();
                    else if (users.ContainsKey(inputData[1])) users.Remove(inputData[1]);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            var result = users.OrderByDescending(x => x.Value.Sum())
                .ThenBy(x => x.Key);

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum()}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while(input != "Statistics")
            {
                string[] inputData = input.Split("->");

                if(inputData[0] == "Add")
                {
                    string username = inputData[1];
                    if (!users.ContainsKey(username)) users[username] = new List<string>();
                    else Console.WriteLine($"{username} is already registered");
                }
                else if ( inputData[0] == "Send")
                {
                    string username = inputData[1];
                    string email = inputData[2];
                    users[username].Add(email);
                }
                else if ( inputData[0] == "Delete")
                {
                    string username = inputData[1];
                    if (users.ContainsKey(username)) users.Remove(username);
                    else Console.WriteLine($"{username} not found!");
                }
                input = Console.ReadLine();
            }

            var result = users.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in result)
            {
                Console.WriteLine(user.Key);
                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($"- {user.Value[i]}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            var facebook = new Dictionary<string, List<int>>();
            string command = Console.ReadLine();

            while (command != "Log out")
            {
                string[] inputData = command.Split(":");

                if (inputData[0].Trim() == "New follower")
                {
                    string username = inputData[1].Trim();
                    if (!facebook.ContainsKey(username))
                    {
                        facebook[username] = new List<int>();
                        facebook[username].Add(0);
                        facebook[username].Add(0);
                    }
                }
                else if (inputData[0].Trim() == "Like")
                {
                    string username = inputData[1].Trim();
                    int likes = int.Parse(inputData[2].Trim());
                    if (!facebook.ContainsKey(username))
                    {
                        facebook[username] = new List<int>();
                        facebook[username].Add(likes);
                        facebook[username].Add(0);
                    }
                    else facebook[username][0] += likes;
                }
                else if (inputData[0].Trim() == "Comment")
                {
                    string username = inputData[1].Trim();
                    if (!facebook.ContainsKey(username))
                    {
                        facebook[username] = new List<int>();
                        facebook[username].Add(0);
                        facebook[username].Add(1);
                    }
                    else facebook[username][1] += 1;
                }
                else if (inputData[0].Trim() == "Blocked")
                {
                    string username = inputData[1].Trim();
                    if (facebook.ContainsKey(username))
                    {
                        facebook.Remove(username);
                    }
                    else Console.WriteLine($"{username} doesn't exist.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{facebook.Count} followers");

            var result = facebook.OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key);

            foreach (var follower in result)
            {
                string username = follower.Key;
                int activity = follower.Value[0] + follower.Value[1];

                Console.WriteLine($"{username}: {activity}");
            }
        }
    }
}
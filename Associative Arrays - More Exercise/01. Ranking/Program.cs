using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            string command = Console.ReadLine();
            while(command!="end of contests")
            {
                string[] input = command.Split(":");
                string contest = input[0];
                string password = input[1];
                contests[contest] = password;
                command = Console.ReadLine();
            }
            var users = new Dictionary<string, Dictionary<string,int>>();
            string submission = Console.ReadLine();
            while(submission!="end of submissions")
            {
                string[] input = submission.Split("=>");
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);
                if(contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, int>();
                        users[username].Add(contest, points);
                    }
                    else if (!users[username].ContainsKey(contest))
                    {
                        users[username].Add(contest, points);
                    }
                    else if(users[username].ContainsKey(contest))
                    {
                        if (users[username][contest] < points) users[username][contest] = points;
                    }
                }
                submission = Console.ReadLine();
            }
            var best = users                
                .OrderByDescending(x => x.Value.Values.Sum()) ;

            foreach (var item in best)
            {
                Console.WriteLine($"Best candidate is {item.Key} with total {item.Value.Values.Sum()} points.");
                break;
            }
            Console.WriteLine("Ranking: ");
            var results = users
                .OrderBy(x => x.Key);
            foreach (var item in results)
            {
                Console.WriteLine($"{item.Key}");
                Dictionary<string, int> nestedDict = item.Value;
                var result = nestedDict.OrderByDescending(x => x.Value);
                foreach (var dict in result)
                {
                    Console.WriteLine($"#  {dict.Key} -> {dict.Value}");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var judge = new Dictionary<string, Dictionary<string, long>>();
            var students = new Dictionary<string, long>();
            string command = Console.ReadLine();
            while(command!="no more time")
            {
                string[] input = command.Split(" -> ");
                string username = input[0];
                string contest = input[1];
                long points = int.Parse(input[2]);
                long pointsToAdd = 0;
                if (!judge.ContainsKey(contest))
                {
                    judge[contest] = new Dictionary<string, long>();
                    judge[contest].Add(username, points);
                    pointsToAdd = points;
                }
                else if (judge.ContainsKey(contest) && !judge[contest].ContainsKey(username))
                {
                    judge[contest].Add(username, points);
                    pointsToAdd = points;
                }
                else if (judge.ContainsKey(contest) && judge[contest].ContainsKey(username))
                {
                    if (judge[contest][username] < points)
                    {
                        pointsToAdd = points - judge[contest][username];
                        judge[contest][username] = points;
                    }
                }
                if(!students.ContainsKey(username))
                {
                    students.Add(username, pointsToAdd);
                }
                else students[username] += pointsToAdd;
                command = Console.ReadLine();
            }
            foreach (var item in judge)
            {
                Dictionary<string, long> innerDict = item.Value;
                Console.WriteLine($"{item.Key}: {innerDict.Keys.Count} participants");
                var result = innerDict
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);
                int counter = 0;
                foreach (var student in result)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
                }
            }
            Console.WriteLine("Individual standings:");
            int rank = 0;
            var ranking = students
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            foreach (var item in ranking)
            {
                rank++;
                Console.WriteLine($"{rank}. {item.Key} -> {item.Value}");                
            }            
        }
    }
}
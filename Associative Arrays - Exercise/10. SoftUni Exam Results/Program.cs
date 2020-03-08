using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, int>();
            var submissions = new Dictionary<string, int>();
            string command = "";
            command = Console.ReadLine();
            while(command != "exam finished")
            {
                string[] input = command.Split("-").ToArray();
                if(input[1] != "banned")
                {
                    string username = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);
                    if (!students.ContainsKey(username))
                    {
                        students[username] = 0;
                    }
                    if(students[username] < points) students[username] = points;
                    if (!submissions.ContainsKey(language))
                    {
                        submissions[language] = 0;
                    }
                    submissions[language] ++;
                }
                else
                {
                    string username = input[0];
                    if (students.ContainsKey(username)) students.Remove(username);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            var result = students
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            var result2 = submissions
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
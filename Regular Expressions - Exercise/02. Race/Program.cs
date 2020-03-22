using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            var participants = new Dictionary<string, int>();

            foreach (var person in people)
            {
                participants[person] = 0;
            }
            string command = Console.ReadLine();
            while(command!="end of race")
            {
                string name = string.Empty;
                foreach (var symbol in command)
                {
                    if (char.IsLetter(symbol)) name += symbol;
                }
                if (participants.ContainsKey(name))
                {
                    int distance = 0;
                    foreach (var digit in command)
                    {
                        if (char.IsDigit(digit)) distance += int.Parse(digit.ToString());
                    }
                    participants[name] += distance;
                }
                command = Console.ReadLine();
            }
            var result = participants.OrderByDescending(x => x.Value).Take(3);
            int rank = 1;
            foreach (var player in result)
            {
                if (rank == 1)
                {
                    Console.WriteLine($"1st place: {player.Key}");
                }
                else if ( rank == 2)
                {
                    Console.WriteLine($"2nd place: {player.Key}");
                }
                else
                {
                    Console.WriteLine($"3rd place: {player.Key}");
                }
                rank++;
            }
        }
    }
}
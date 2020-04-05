using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Nikulden_s_meals
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            int unlikedMeals = 0;
            
            while(command != "Stop")
            {
                string[] inputData = command.Split("-");
                string guest = inputData[1];
                string meal = inputData[2];
                if (inputData[0] == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests[guest] = new List<string>();
                        guests[guest].Add(meal);
                    }
                    else if (guests.ContainsKey(guest) && !guests[guest].Contains(meal))
                    {
                        guests[guest].Add(meal);
                    }
                }
                else if (inputData[0] == "Unlike")
                {
                    if (!guests.ContainsKey(guest)) Console.WriteLine($"{guest} is not at the party.");
                    else if (guests.ContainsKey(guest) && !guests[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        unlikedMeals++;
                        guests[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                    }
                }
                command = Console.ReadLine();
            }

            var result = guests.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);

            foreach (var guest in result)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ",guest.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals}");
        }
    }
}
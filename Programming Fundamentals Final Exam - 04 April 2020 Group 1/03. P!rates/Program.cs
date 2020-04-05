using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var citiesStats = new Dictionary<string, List<int>>();

            string command = Console.ReadLine();

            while(command != "Sail")
            {
                string[] entries = command.Split("||");
                string city = entries[0];
                int population = int.Parse(entries[1]);
                int gold = int.Parse(entries[2]);
                if (!citiesStats.ContainsKey(city))
                {
                    citiesStats[city] = new List<int>();
                    citiesStats[city].Add(population);
                    citiesStats[city].Add(gold);
                }
                else
                {
                    citiesStats[city][0] += population;
                    citiesStats[city][1] += gold;
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while ( command != "End")
            {
                string[] inputData = command.Split("=>");

                if(inputData[0] == "Plunder")
                {
                    string town = inputData[1];
                    int people = int.Parse(inputData[2]);
                    int gold = int.Parse(inputData[3]);

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    citiesStats[town][0] -= people;
                    citiesStats[town][1] -= gold;
                    if(citiesStats[town][0] <=0 || citiesStats[town][1] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        citiesStats.Remove(town);
                    } 
                }
                else if ( inputData[0] == "Prosper")
                {
                    string town = inputData[1];                    
                    int gold = int.Parse(inputData[2]);
                    if (gold < 0) Console.WriteLine("Gold added cannot be a negative number!");
                    else
                    {
                        citiesStats[town][1] += gold;
                        int townGold = citiesStats[town][1];
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townGold} gold.");
                    }
                }
                command = Console.ReadLine();
            }

            if (citiesStats.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesStats.Count} wealthy settlements to go to:");
                var cities = citiesStats.OrderByDescending(x => x.Value[1])
                    .ThenBy(x => x.Key);

                foreach (var city in cities)
                {
                    string town = city.Key;
                    int people = city.Value[0];
                    int gold = city.Value[1];
                    Console.WriteLine($"{town} -> Population: {people} citizens, Gold: {gold} kg");
                }
            }
            else Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }
}
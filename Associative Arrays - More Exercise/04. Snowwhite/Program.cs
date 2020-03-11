using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while(command!= "Once upon a time")
            {
                string[] input = command.Split(" <:> ");
                string name = input[0];
                string color = input[1];
                int phisics = int.Parse(input[2]);

                if (!dwarfs.ContainsKey(color))
                {
                    dwarfs[color] = new Dictionary<string, int>();
                    dwarfs[color].Add(name, phisics);
                }
                else if (!dwarfs[color].ContainsKey(name))
                {
                    dwarfs[color].Add(name, phisics);
                }
                else if (phisics > dwarfs[color][name])
                {
                    dwarfs[color][name] = phisics; 
                }
                command = Console.ReadLine();
            }

            var result = dwarfs.OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Count());
            foreach (var item in result)
            {
                Dictionary<string, int> inner = item.Value;
                var ranking = inner.OrderByDescending(x => x.Value);
                foreach (var dwarf in ranking)
                {
                    Console.WriteLine($"({item.Key}) {dwarf.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
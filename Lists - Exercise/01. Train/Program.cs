using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = "";
            command = Console.ReadLine();
            while (command != "end")
            {
                if(command == "end")
                {
                    Console.WriteLine(string.Join(' ',trainWagons));
                    return;
                }
                string[] input = command.Split().ToArray();
                if (input[0] == "Add") trainWagons.Add(int.Parse(input[1]));
                else
                {
                    int incomingPassengers = int.Parse(input[0]);
                    for (int i = 0; i < trainWagons.Count; i++)
                    {
                        if (incomingPassengers + trainWagons[i] <= wagonCapacity)
                        {
                            trainWagons[i] += incomingPassengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',trainWagons));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxSectionHealt = int.Parse(Console.ReadLine());
            string command = "";
            command = Console.ReadLine();
            while (command != "Retire")
            {
                string[] inputData = command.Split();
                if (inputData[0] == "Fire")
                {
                    if (int.Parse(inputData[1]) >= 0 && int.Parse(inputData[1]) <= warship.Count - 1)
                    {
                        int damage = int.Parse(inputData[2]);
                        if (damage >= warship[int.Parse(inputData[1])])
                        {
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            return;
                        }
                        else warship[int.Parse(inputData[1])] -= damage;
                    }
                }
                else if (inputData[0] == "Defend")
                {
                    if (int.Parse(inputData[1]) >= 0 && int.Parse(inputData[1]) <= pirateShip.Count - 1
                        && int.Parse(inputData[2]) >= 0 && int.Parse(inputData[2]) <= pirateShip.Count - 1)
                    {
                        int start = int.Parse(inputData[1]);
                        int end = int.Parse(inputData[2]);
                        int damage = int.Parse(inputData[3]);
                        for (int i = start; i <= end; i++)
                        {
                            if (damage >= pirateShip[i])
                            {
                                Console.WriteLine($"You lost! The pirate ship has sunken.");
                                return;
                            }
                            else pirateShip[i] -= damage;
                        }
                    }
                }
                else if (inputData[0] == "Repair")
                {
                    if (int.Parse(inputData[1]) >= 0 && int.Parse(inputData[1]) <= pirateShip.Count - 1)
                    {
                        int index = int.Parse(inputData[1]);
                        int health = int.Parse(inputData[2]);
                        int healthSection = pirateShip[index];
                        if (healthSection + health > maxSectionHealt) pirateShip[index] = maxSectionHealt;
                        else pirateShip[index] += health;
                    }
                }
                else if (inputData[0] == "Status")
                {
                    int counter = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < maxSectionHealt * 0.2) counter++;
                    }
                    Console.WriteLine($"{counter} sections need repair.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warship.Sum()}");
        }
    }
}
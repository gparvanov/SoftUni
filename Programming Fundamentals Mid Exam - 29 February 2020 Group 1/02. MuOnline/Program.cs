using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;

            List<string> rooms = Console.ReadLine().Split("|").ToList();
            int reachedRoom = 0;
            for (int i = 0; i < rooms.Count; i++)
            {
                string[] command = rooms[i].Split().ToArray();
                reachedRoom++;
                if (command[0] == "potion")
                {
                    int potion = int.Parse(command[1]);
                    health += potion;
                    int difference = 0;
                    if (health > 100)
                    {
                        difference = Math.Abs(health - 100 - potion);
                        health = 100;
                    }
                    else difference = potion;
                    Console.WriteLine($"You healed for {difference} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if ( command[0] == "chest")
                {
                    int foundBitcoins = int.Parse(command[1]);
                    bitcoins += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");                    
                }
                else
                {
                    string monster = command[0];
                    int attack = int.Parse(command[1]);
                    if(attack<health)
                    {
                        health -= attack;
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {reachedRoom}");
                        return;
                    }
                }                
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}

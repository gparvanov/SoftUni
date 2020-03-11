using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var dragons = new Dictionary<string, Dictionary<string,List<int>>>();

            for (int i = 1; i <= number; i++)
            {
                string command = Console.ReadLine();
                string[] input = command.Split();
                string type = input[0];
                string name = input[1];
                if (input[2] == "null") input[2] = "45";
                if (input[3] == "null") input[3] = "250";
                if (input[4] == "null") input[4] = "10";
                int damage = int.Parse(input[2]);
                int health = int.Parse(input[3]);
                int armor = int.Parse(input[4]);
                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new Dictionary<string, List<int>>();
                    var list = new List<int>();
                    list.Add(damage);
                    list.Add(health);
                    list.Add(armor);
                    dragons[type].Add(name,list);
                }
                else if ( dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                {
                    dragons[type][name][0] = damage;
                    dragons[type][name][1] = health;
                    dragons[type][name][2] = armor;
                }
                else
                {                    
                    var list = new List<int>();
                    list.Add(damage);
                    list.Add(health);
                    list.Add(armor);
                    dragons[type].Add(name, list);
                }
            }
            foreach (var type in dragons)
            {
                string dragonType = type.Key;
                int count = 0;
                int sumDamage = 0;
                int sumHealth = 0;
                int sumArmor = 0;
                foreach (var item in type.Value)
                {
                    count++;
                    sumDamage += item.Value[0];
                    sumHealth += item.Value[1];
                    sumArmor += item.Value[2];
                }
                Console.WriteLine($"{dragonType}::({sumDamage*1.0/count:F2}/{sumHealth*1.0/count:F2}/{sumArmor*1.0/count:F2})");
                
                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    string name = dragon.Key;
                    var attributes = dragon.Value;
                    Console.WriteLine($"-{name} -> damage: {attributes[0]}, health: {attributes[1]}, armor: {attributes[2]}");
                }
            }
        }
    }
}
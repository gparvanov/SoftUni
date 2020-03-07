using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> materials = Console.ReadLine().Split().ToList();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["shards"] = 0;
            dict["fragments"] = 0;
            dict["motes"] = 0;
            bool purchased = false;
            while (!purchased)
            {
                for (int i = 0; i < materials.Count; i+=2)
                {
                    int value = int.Parse(materials[i]);
                    string item = materials[i + 1].ToLower();
                    if (!dict.ContainsKey(item))
                    {
                        dict[item] = 0;
                    }
                    dict[item] += value;

                    if (item == "shards" && dict[item] >= 250)
                    {
                        Console.WriteLine($"Shadowmourne obtained!");
                        dict[item] -= 250;
                        purchased = true;
                        break;
                    }
                    else if (item == "fragments" && dict[item] >= 250)
                    {
                        Console.WriteLine($"Valanyr obtained!");
                        dict[item] -= 250;
                        purchased = true;
                        break;
                    }
                    else if (item == "motes" && dict[item] >= 250)
                    {
                        Console.WriteLine($"Dragonwrath obtained!");
                        dict[item] -= 250;
                        purchased = true;
                        break;
                    }                    
                }
                if (!purchased) materials = Console.ReadLine().Split().ToList();
            }
            var result = dict.Where(x => x.Key == "shards" || x.Key == "fragments" || x.Key == "motes")
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            var result2 = dict.Where(x => x.Key != "shards" && x.Key != "fragments" && x.Key != "motes")
                .OrderBy(x => x.Key);
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

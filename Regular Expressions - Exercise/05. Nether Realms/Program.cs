using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deamons = Regex.Split(Console.ReadLine(), @",\s*");
            var result = new Dictionary<string, List<decimal>>();
            foreach (var deamon in deamons)
            {
                string name = deamon.Trim();
                if (name.Contains(',')) continue;
                else if (name.Contains(' ')) continue;
                long health = 0;
                decimal damage = 0;                
                int countMultiplications = 0;
                int countDividers = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsDigit(name[i]) && name[i] != '+' && name[i] != '-'
                        && name[i] != '/' && name[i] != '*' && name[i] != '.') health += name[i];
                    else if (name[i] == '*') countMultiplications++;
                    else if (name[i] == '/') countDividers++;                    
                }
                if (health <= 0) continue;

                string regex = @"(\+|-)*(\d+(\.\d+)*)";

                var numbers = Regex.Matches(name, regex);
                if (numbers.Count > 0)
                {
                    foreach (Match number in numbers)
                    {
                        damage += decimal.Parse(number.Value);                        
                    }
                }
                if (countDividers > 0)
                {
                    for (int i = 1; i <= countDividers; i++)
                    {
                        damage /= 2 * 1.0m;
                    }                    
                }
                if (countMultiplications > 0)
                {
                    for (int i = 1; i <= countMultiplications; i++)
                    {
                        damage *= 2;
                    }
                }
                result[name] = new List<decimal>();
                result[name].Add(health);
                result[name].Add(damage);
            }
            var result2 = result.OrderBy(x => x.Key);
            foreach (var deamon in result2)
            {
                string name = deamon.Key;
                var innerList = deamon.Value;
                Console.WriteLine($"{name} - {innerList[0]} health, {innerList[1]:f2} damage");
            }
        }
    }
}
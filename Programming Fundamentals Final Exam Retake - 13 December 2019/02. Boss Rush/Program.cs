using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                string regex = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";

                var data = Regex.Matches(input, regex);
                if (data.Count > 0)
                {
                    foreach (Match boss in data)
                    {
                        string name = boss.Groups["boss"].Value;
                        string title = boss.Groups["title"].Value;

                        Console.WriteLine($"{name}, The {title}");
                        Console.WriteLine($">> Strength: {name.Length}");
                        Console.WriteLine($">> Armour: {title.Length}");
                    }
                }
                else Console.WriteLine("Access denied!"); 
            }
        }
    }
}

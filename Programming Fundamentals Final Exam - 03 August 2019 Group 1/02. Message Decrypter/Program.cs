using System;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string regex = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<d1>\d+)\]\|\[(?<d2>\d+)\]\|\[(?<d3>\d+)\]\|$";

                Match found = Regex.Match(input, regex);

                if (found.Success)
                {
                    string tag = found.Groups["tag"].Value;
                    int first = int.Parse(found.Groups["d1"].Value);
                    int second = int.Parse(found.Groups["d2"].Value);
                    int third = int.Parse(found.Groups["d3"].Value);
                    Console.WriteLine($"{tag}: {(char)first}{(char)second}{(char)third}");
                }
                else Console.WriteLine($"Valid message not found!");
            }
        }
    }
}
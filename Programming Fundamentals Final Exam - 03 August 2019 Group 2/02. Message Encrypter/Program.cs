using System;
using System.Text.RegularExpressions;

namespace _02._Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                string regex = @"(\*|\@)(?<tag>[A-Z][a-z]{2,})\1: \[(\w)\]\|\[(\w)\]\|\[(\w)\]\|$";

                Match result = Regex.Match(text, regex);

                if (result.Success)
                {
                    string tag = result.Groups["tag"].Value;

                    string w1 = result.Groups[2].Value;
                    string w2 = result.Groups[3].Value;
                    string w3 = result.Groups[4].Value;
                    string toPrint = string.Empty;
                    foreach (var item in w1)
                    {
                        int value = item;
                        toPrint += value + " ";
                    }
                    foreach (var item in w2)
                    {
                        int value = item;
                        toPrint += value + " ";
                    }
                    foreach (var item in w3)
                    {
                        int value = item;
                        toPrint += value + " ";
                    }
                    Console.Write($"{tag}: {toPrint}");
                    Console.WriteLine();
                }
                else Console.WriteLine("Valid message not found!");
            }
        }
    }
}
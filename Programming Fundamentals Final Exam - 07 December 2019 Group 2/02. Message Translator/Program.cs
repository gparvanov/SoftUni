using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();
                string regex = @"!(?<command>[A-Z][a-z]{3,})!:\[(?<message>[A-Za-z]{8,})\]";

                var data = Regex.Matches(text, regex);
                if (data.Count > 0)
                {
                    foreach (Match code in data)
                    {
                        string command = code.Groups["command"].Value;
                        string message = code.Groups["message"].Value;
                        Console.Write($"{command}: ");
                        for (int j = 0; j < message.Length; j++)
                        {
                            int number = message[j];
                            Console.Write($"{number} ");
                        }
                        Console.WriteLine();
                    }
                }
                else Console.WriteLine("The message is invalid");
            }
        }
    }
}
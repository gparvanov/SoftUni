using System;
using System.Text.RegularExpressions;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string password = Console.ReadLine();
                string regex = @"(.+)>(\d{3,3})\|([a-z]{3,3})\|([A-Z]{3,3})\|([^<>].+)<\1$";
                Match pwd = Regex.Match(password, regex);

                if (pwd.Success)
                {
                    string g1 = pwd.Groups[2].Value;
                    string g2 = pwd.Groups[3].Value;
                    string g3 = pwd.Groups[4].Value;
                    string g4 = pwd.Groups[5].Value;
                    Console.WriteLine($"Password: {g1}{g2}{g3}{g4}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
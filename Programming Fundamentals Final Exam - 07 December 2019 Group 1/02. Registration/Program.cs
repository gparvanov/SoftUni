using System;
using System.Text.RegularExpressions;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int regs = int.Parse(Console.ReadLine());
            int successfullRegs = 0;
            
            for (int i = 0; i < regs; i++)
            {
                string input = Console.ReadLine();
                string regex = @"(U\$(?<username>[A-Z][a-z]{2,})U\$)(P\@\$(?<password>[A-Za-z]{5,}[A-Za-z0-9]*[0-9]{1})P\@\$)";

                var data = Regex.Matches(input, regex);

                if (data.Count > 0)
                {
                    foreach (Match user in data)
                    {
                        string username = user.Groups["username"].Value;
                        string password = user.Groups["password"].Value;
                        Console.WriteLine("Registration was successful");
                        Console.WriteLine($"Username: {username}, Password: {password}");
                        successfullRegs++;
                    }
                }
                else Console.WriteLine("Invalid username or password");
            }
            Console.WriteLine($"Successful registrations: {successfullRegs}");
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\s[A-Za-z0-9][A-Za-z0-9\-_.]+[A-Za-z0-9]+@[A-Za-z0-9][A-Za-z0-9\-_.]+[A-Za-z0-9]+\.[A-Za-z0-9][A-Za-z]+((\.)([A-Za-z0-9][A-Za-z]+))*";

            string text = Console.ReadLine();

            var data = Regex.Matches(text, regex);

            foreach (Match email in data)
            {
                Console.WriteLine($"{email.Value.Trim()}");
            }
        }
    }
}

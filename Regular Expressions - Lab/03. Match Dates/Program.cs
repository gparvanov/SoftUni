using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex (@"\b(?<day>\d{2})([-.\/])(?<month>[A-z][a-z]{2})\1(?<year>\d{4})\b");
            var datesString = Console.ReadLine();
            var dates = regex.Matches(datesString);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"];
                var month = date.Groups["month"];
                var year = date.Groups["year"];
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
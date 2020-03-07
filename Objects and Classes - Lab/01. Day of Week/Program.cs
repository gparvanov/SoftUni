using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime day = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            string[] data = date.Split("-");

            var dayOfWeek = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]));

            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}

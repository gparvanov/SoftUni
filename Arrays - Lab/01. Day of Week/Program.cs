using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7];

            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            int input = int.Parse(Console.ReadLine());

            if (input > 0 && input < 8)
            {
                Console.WriteLine(days[input - 1]);
            }
            else Console.WriteLine("Invalid day!");

        }
    }
}

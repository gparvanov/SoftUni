using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalTimeInMinutes = hours * 60 + minutes + 30;

            int newHour = totalTimeInMinutes / 60;
            int newMinutes = totalTimeInMinutes % 60;

            if (newHour > 23)
            {
                Console.WriteLine($"{0}:{newMinutes:D2}");
            }
            else
            {
                Console.WriteLine($"{newHour}:{newMinutes:D2}");
            }
        }
    }
}

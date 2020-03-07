using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double gainedPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0) gainedPlunder += dailyPlunder * 1.5;
                else gainedPlunder += dailyPlunder;
                if (i % 5 == 0) gainedPlunder *= 0.7;
            }
            if (gainedPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {gainedPlunder:F2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {gainedPlunder/expectedPlunder*100:F2}% of the plunder.");
            }
        }
    }
}
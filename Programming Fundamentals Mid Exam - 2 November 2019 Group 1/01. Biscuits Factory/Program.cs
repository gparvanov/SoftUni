using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double competitorProduction = double.Parse(Console.ReadLine());

            int sumDailyProduction = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 != 0) sumDailyProduction += biscuitsPerDay * workers;
                else sumDailyProduction += (int)Math.Floor(biscuitsPerDay * workers * 0.75);
            }
            Console.WriteLine($"You have produced {sumDailyProduction} biscuits for the past month.");
            if(sumDailyProduction >= competitorProduction)
            {
                Console.WriteLine($"You produce {(sumDailyProduction - competitorProduction)/competitorProduction * 100.0:F2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {(competitorProduction - sumDailyProduction) /competitorProduction * 100.0:F2} percent less biscuits.");
            }
        }
    }
}

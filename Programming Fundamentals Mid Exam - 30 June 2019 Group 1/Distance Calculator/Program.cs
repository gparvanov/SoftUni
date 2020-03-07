using System;

namespace Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            double oneStepLength = double.Parse(Console.ReadLine());
            int distanceToBeTravelled = int.Parse(Console.ReadLine());

            double passedDistance = (steps * oneStepLength / 100) - (((steps/5 * oneStepLength) / 100) * 0.3);

            Console.WriteLine($"You travelled {passedDistance/distanceToBeTravelled*100:F2}% of the distance!");
        }
    }
}

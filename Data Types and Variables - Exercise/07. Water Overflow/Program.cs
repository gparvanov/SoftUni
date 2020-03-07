using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int leftTankCapacity = 255;
            int attempts = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= attempts; i++)
            {
                int incomingWater = int.Parse(Console.ReadLine());

                if(leftTankCapacity - incomingWater >= 0)
                {
                    leftTankCapacity -= incomingWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine($"{tankCapacity - leftTankCapacity}");
        }
    }
}

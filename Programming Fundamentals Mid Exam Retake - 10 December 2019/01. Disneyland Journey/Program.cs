using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyExpences = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double collectedMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 2 != 0 && i != 1) collectedMoney *= 0.84;
                if (i % 4 == 0) collectedMoney *= 1.25;
                collectedMoney += journeyExpences * 0.25;
            }
            if(collectedMoney>=journeyExpences)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {collectedMoney-journeyExpences:F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyExpences - collectedMoney:F2}lv. more.");
            }
        }
    }
}

using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int workedDays = 0;
            int extractedYield = 0;
            int currentYield = startingYield;


            while (currentYield >= 100)
            {
                workedDays++;
                extractedYield += currentYield;
                extractedYield -= 26;
                currentYield -= 10;
                if (currentYield < 100)
                {
                    extractedYield -= 26;
                    break;
                }
            }

            Console.WriteLine($"{workedDays}");
            Console.WriteLine($"{extractedYield}");

        }
    }
}

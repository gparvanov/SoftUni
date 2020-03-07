using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalOddSum = 0;
            int foundOdds = 0;
            for (int i = 1; i <= number*2; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                    foundOdds++;
                    totalOddSum += i;
                }
                if (foundOdds >= number) break;
            }
            Console.WriteLine($"Sum: {totalOddSum}");
        }
    }
}

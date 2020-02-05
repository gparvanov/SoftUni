using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                                .Split()
                                .Select(double.Parse)
                                .ToArray();
            long[] roundedNumbers = new long[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (long)Math.Round(numbers[i],MidpointRounding.AwayFromZero);                
            }

            for (int j = 0; j < roundedNumbers.Length; ++j)
            {
                Console.WriteLine($"{numbers[j]} => {roundedNumbers[j]}");
            }
        }
    }
}

using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length != 1)
            {
                int[] condensed = new int[numbers.Length-1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = new int[condensed.Length];
                for (int j = 0; j < condensed.Length; j++)
                {
                    numbers[j] = condensed[j];
                }
            }
            Console.WriteLine($"{numbers[0]}");
        }
    }
}

using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] array = new int[wagons];

            int sumTotalPassengers = 0;

            for (int i = 0; i < wagons; i++)
            {
                int currentWagonPassengers = int.Parse(Console.ReadLine());
                array[i] = currentWagonPassengers;
                sumTotalPassengers += currentWagonPassengers;
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write($"{array[j]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{sumTotalPassengers}");
        }
    }
}

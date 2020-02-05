using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                numbers[i] = current;
            }

            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}

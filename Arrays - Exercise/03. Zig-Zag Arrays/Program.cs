using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsToRead = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[rowsToRead];
            int[] arrayTwo = new int[rowsToRead];

            for (int i = 0; i < rowsToRead; i++)
            {
                int[] temporaryArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
                  
                if (i % 2 == 0)
                {
                    arrayOne[i] = temporaryArray[0];
                    arrayTwo[i] = temporaryArray[1];
                }
                else
                {
                    arrayOne[i] = temporaryArray[1];
                    arrayTwo[i] = temporaryArray[0];
                }
            }

            for (int i = 0; i < rowsToRead; i++)
            {
                Console.Write($"{arrayOne[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < rowsToRead; i++)
            {
                Console.Write($"{arrayTwo[i]} ");
            }
            Console.WriteLine();
        }
    }
}

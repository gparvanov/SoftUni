using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int firstElement = lineArray[0];

                for (int j= 0; j < lineArray.Length-1; j++)
                {
                    lineArray[j] = lineArray[j + 1];
                }
                lineArray[lineArray.Length - 1] = firstElement;

            }
            for (int i = 0; i < lineArray.Length; i++)
            {
                Console.Write($"{lineArray[i]} ");
            }
        }
    }
}

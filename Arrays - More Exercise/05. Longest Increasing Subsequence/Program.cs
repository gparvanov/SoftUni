using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string longestSequence = "";
            int lowestRank = 0;
            int addedElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string currentSequence = array[i] + " ";
                int currentRank = i;
                int prevElement = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] > array[i] && array[j] > prevElement)
                    {
                        currentSequence += array[j] + " ";
                        currentRank += j;
                        prevElement = array[j];
                    }
                }                
                if (currentSequence.Length > longestSequence.Length) 
                {
                    longestSequence = currentSequence;
                    lowestRank = currentRank;
                }
                //else if (currentSequence.Length == longestSequence.Length && currentRank < lowestRank)
                //{
                //    longestSequence = currentSequence;
                //    lowestRank = currentRank;
                //}
            }
            Console.WriteLine($"{longestSequence}");
        }
    }
}

using System;
using System.Linq;


namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSeqCounter = 1;
            int currentSeqCounter = 0;
            int longestSeqNumber = array[0];
            int prevNumber = array[0];
            
            for (int i = 0; i < array.Length; i++)
            {
                currentSeqCounter++;
                if (array[i] == prevNumber)
                {
                    if (currentSeqCounter > longestSeqCounter)
                    {
                        longestSeqCounter = currentSeqCounter;
                        longestSeqNumber = array[i];
                    }
                }
                else
                {
                    prevNumber = array[i];
                    currentSeqCounter = 1;                    
                }
            }
            if (longestSeqCounter > 1)
            {
                for (int i = 0; i < longestSeqCounter; i++)
                {
                    Console.Write($"{longestSeqNumber} ");
                }
            }
        }
    }
}

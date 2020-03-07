using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] incomingArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int groupKIntegers = incomingArray.Length / 4;

            string firstRowString = "";
            for (int i = groupKIntegers -1 ; i >=0 ; i--)
            {
                firstRowString += incomingArray[i] + " ";                
            }
            for (int i = incomingArray.Length-1; i >= incomingArray.Length - groupKIntegers ; i--)
            {
                firstRowString += incomingArray[i] + " ";
            }            
            string secondRowString = "";
            for (int i = groupKIntegers ; i <= incomingArray.Length - 1 - groupKIntegers; i++)
            {
                secondRowString += incomingArray[i] + " ";
            }           
            int[] firstRow = firstRowString.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondRow = secondRowString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < firstRow.Length; i++)
            {
                Console.Write($"{firstRow[i] + secondRow[i]} ");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> queueOfLists = Console.ReadLine().Split('|',StringSplitOptions.RemoveEmptyEntries).ToList();

            List<int> listOfNumbers = new List<int>();
            
            for (int i = queueOfLists.Count-1; i >=0; i--)
            {
                List<int> tempList = queueOfLists[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < tempList.Count; j++)
                {
                    listOfNumbers.Add(tempList[j]);
                }
            }
            Console.WriteLine(string.Join(' ',listOfNumbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int elementsToInstert = Math.Min(list1.Count, list2.Count);
            for (int i = 0; i < elementsToInstert; i++)
            {
                result.Add(list1[0]);
                list1.RemoveAt(0);
                result.Add(list2[list2.Count - 1]);
                list2.RemoveAt(list2.Count - 1);
                if (list1.Count == 0 || list2.Count == 0) break;
            }
            int minRange = 0;
            int maxRange = 0;
            if (list1.Count > 0)
            {
                minRange = Math.Min(list1[0], list1[1]);
                maxRange = Math.Max(list1[0], list1[1]);
            }
            else
            {
                minRange = Math.Min(list2[0], list2[1]);
                maxRange = Math.Max(list2[0], list2[1]);
            }
            result.Sort();
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > minRange && result[i] < maxRange) Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
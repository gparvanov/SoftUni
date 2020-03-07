using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string topIntegers = "";

            for (int i = 0; i < integers.Length; i++)
            {
                int top = integers[i];
                bool isTop = false;
                for (int j = i+1; j < integers.Length; j++)
                {
                    if (top > integers[j]) isTop = true;
                    else break;
                }
                if (isTop == true || i==integers.Length-1) topIntegers += integers[i] + " ";                                
            }
            if (topIntegers != "") Console.WriteLine($"{topIntegers}");
        }
    }
}

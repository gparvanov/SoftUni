using System;
using System.Linq;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(String.Concat(Enumerable.Repeat(words[i],words[i].Length)));                
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToList()
                .OrderByDescending(x => x)
                .Reverse()
                .TakeLast(3)
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
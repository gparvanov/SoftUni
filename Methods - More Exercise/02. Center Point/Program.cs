using System;
using System.Numerics;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            PrintClosestToZeroPoint(x1, y1, x2, y2);
        }
        static void PrintClosestToZeroPoint(decimal x1 , decimal y1, decimal x2 , decimal y2)
        {
            decimal sum1 = Math.Abs(x1) + Math.Abs(y1);
            decimal sum2 = Math.Abs(x2) + Math.Abs(y2);
            if (sum1 <= sum2) Console.WriteLine($"({x1}, {y1})");
            else Console.WriteLine($"({x2}, {y2})");
        }
    }
}
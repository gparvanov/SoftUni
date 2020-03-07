using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lx1 = decimal.Parse(Console.ReadLine());
            decimal ly1 = decimal.Parse(Console.ReadLine());
            decimal lx2 = decimal.Parse(Console.ReadLine());
            decimal ly2 = decimal.Parse(Console.ReadLine());
            decimal l2x1 = decimal.Parse(Console.ReadLine());
            decimal l2y1 = decimal.Parse(Console.ReadLine());
            decimal l2x2 = decimal.Parse(Console.ReadLine());
            decimal l2y2 = decimal.Parse(Console.ReadLine());
            PrintClosestToZeroPoint(lx1, ly1, lx2, ly2, l2x1, l2y1, l2x2, l2y2);
        }
        static void PrintClosestToZeroPoint(decimal lx1, decimal ly1, decimal lx2, decimal ly2, decimal l2x1, decimal l2y1, decimal l2x2, decimal l2y2)
        {
            decimal suml1 = Math.Abs(lx1) + Math.Abs(ly1);
            decimal suml2 = Math.Abs(lx2) + Math.Abs(ly2);
            decimal suml21 = Math.Abs(l2x1) + Math.Abs(l2y1);
            decimal suml22 = Math.Abs(l2x2) + Math.Abs(l2y2);
            if (suml1 + suml2 >= suml21 + suml22)
            {
                if(suml1<=suml2) Console.WriteLine($"({lx1}, {ly1})({lx2}, {ly2})");
                else Console.WriteLine($"({lx2}, {ly2})({lx1}, {ly1})");
            }
            else
            {
                if (suml21 <= suml22) Console.WriteLine($"({l2x1}, {l2y1})({l2x2}, {l2y2})");
                else Console.WriteLine($"({l2x2}, {l2y2})({l2x1}, {l2y1})");
            }
        }
    }
}

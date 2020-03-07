using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());

                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}

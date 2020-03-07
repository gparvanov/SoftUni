using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());

            long result = Factorial(number1) / Factorial(number2);

            Console.WriteLine($"{result:F2}");
        }
        static long Factorial(long number)
        {
            long result = 1;
            for (long i = number; i >=1 ; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
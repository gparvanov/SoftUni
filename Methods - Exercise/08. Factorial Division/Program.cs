using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double result = Factorial(number1) * 1.0 / Factorial(number2);

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
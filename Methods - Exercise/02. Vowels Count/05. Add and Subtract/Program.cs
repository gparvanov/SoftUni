using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int summing = Sum(number1, number2);
            int result = Subtract(summing, number3);

            Console.WriteLine($"{result}");
        }
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }

    }
}
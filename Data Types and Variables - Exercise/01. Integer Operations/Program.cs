using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            int division = sum / divider;

            int result = division * multiplier;

            Console.WriteLine($"{result}");
        }
    }
}

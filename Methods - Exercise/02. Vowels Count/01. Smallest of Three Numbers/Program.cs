using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            SmallestOfThree(number1, number2, number3);
        }
        static void SmallestOfThree (int num1, int num2, int num3)
        {
            int smallest = Math.Min(num1, Math.Min(num2, num3));
            Console.WriteLine(smallest);
            
        }
    }
}

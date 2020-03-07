using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int digits = number.Length;

            int digitsSum = 0;

            for (int i = 0; i < digits; i++)
            {
                digitsSum += number[i] - '0';
            }

            Console.WriteLine(digitsSum);
        }
    }
}

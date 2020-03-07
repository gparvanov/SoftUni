using System;
using System.Linq;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            if (fibonacciNumber < 0 && fibonacciNumber > 50) return;
            if (fibonacciNumber == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (fibonacciNumber == 2)
            {
                Console.WriteLine(1);
                return;
            }
            long[] fibonacci = new long[fibonacciNumber];

            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2; i < fibonacciNumber; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];                
            }
            if (fibonacciNumber == 1) Console.WriteLine(1);
            else if (fibonacciNumber == 2) Console.WriteLine(1);
            else Console.WriteLine($"{fibonacci[fibonacciNumber-1]}");
        }
    }
}

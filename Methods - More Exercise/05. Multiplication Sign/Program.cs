using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            IsPositiveResult(number1,number2,number3);
        }
        static void IsPositiveResult(int a, int b, int c)
        {
            if (a < 0 && b > 0 && c > 0) Console.WriteLine("negative");
            else if (a > 0 && b > 0 && c > 0) Console.WriteLine("positive");
            else if (a < 0 && b < 0 && c < 0) Console.WriteLine("negative");
            else if (a > 0 && b < 0 && c > 0) Console.WriteLine("negative");
            else if (a > 0 && b > 0 && c < 0) Console.WriteLine("negative");
            else if (a > 0 && b < 0 && c < 0) Console.WriteLine("positive");
            else if (a < 0 && b > 0 && c < 0) Console.WriteLine("positive");            
            else if (a < 0 && b < 0 && c > 0) Console.WriteLine("positive");
            else if (a == 0 || b == 0 || c == 0) Console.WriteLine("zero");
            else Console.WriteLine("positive");
        }
    }
}

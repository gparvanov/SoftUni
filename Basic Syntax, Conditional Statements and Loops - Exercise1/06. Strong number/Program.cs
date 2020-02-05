using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int number = startNumber;

            int sumFactoriel = 0;

            while ( number != 0)
            {
                int digit = number % 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i; 
                }
                sumFactoriel += factorial;
                number /= 10;
            }
            if (sumFactoriel == startNumber) Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}

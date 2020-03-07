using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Tribonacci(number);
        }
        static void Tribonacci(int number)
        {
            if (number < 0 && number > 50) return;
            if (number == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (number == 2)
            {
                Console.WriteLine("1 1");
                return;
            }
            long[] tribonacci = new long[number];
            tribonacci[0] = 1;
            tribonacci[1] = 1;
            tribonacci[2] = 2;
            for (int i = 3; i < number; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
            if (number == 1) Console.WriteLine(1);
            else if (number == 2) Console.WriteLine("1 1");
            else if (number == 3) Console.WriteLine("1 1 2");
            else Console.WriteLine($"{string.Join(' ',tribonacci)}");
        }
    }
}

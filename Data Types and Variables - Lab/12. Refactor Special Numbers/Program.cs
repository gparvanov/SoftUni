using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
                        
            bool found = false;
            for (int i = 1; i <= numbers; i++)
            {
                int currentNumber = i;
                int total = 0;
                while (currentNumber > 0)
                {
                    total += currentNumber % 10;
                    currentNumber /= 10;
                }
                found = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", i, found);                
            }
        }
    }
}

using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());

            int maxDigit = (Math.Max(Math.Max(firstDigit, secondDigit), thirdDigit));
            int minDigit = (Math.Min(Math.Min(firstDigit, secondDigit), thirdDigit));
            Console.WriteLine(maxDigit);
            if (firstDigit > minDigit && firstDigit < maxDigit) Console.WriteLine(firstDigit);
            else if (secondDigit > minDigit && secondDigit < maxDigit) Console.WriteLine(secondDigit);
            else Console.WriteLine(thirdDigit);           
            Console.WriteLine(minDigit);
        }
    }
}

using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string workingNumber = i.ToString();
                int sumOfDigits = 0;
                for (int j = 0; j < workingNumber.Length; j++)
                {
                    sumOfDigits += int.Parse(workingNumber[j].ToString());
                }
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else 
                {
                    Console.WriteLine($"{i} -> False");
                }

            }            
        }
    }
}

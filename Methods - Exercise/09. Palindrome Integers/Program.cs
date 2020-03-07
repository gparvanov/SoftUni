using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                if (IsPallindrom(number)) Console.WriteLine("true");
                else Console.WriteLine("false");
                number = Console.ReadLine();
            }            
        }
        static bool IsPallindrom(string number)
        {            
            for (int i = 0; i < number.Length/2; i++)
            {
                if(number[i] != number[number.Length - i -1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

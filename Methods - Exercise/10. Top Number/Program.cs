using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool result = TopNumber(i.ToString());
                if (result) Console.WriteLine(i);
            }
        }
        static bool TopNumber(string a)
        {
            int sumDigits = 0;
            bool hasOneDigit = false;
            for (int i = 0; i < a.Length; i++)
            {
                int currentDigit = a[i] - '0';                
                sumDigits += currentDigit;
                if (!hasOneDigit && currentDigit % 2 != 0) hasOneDigit = true;                                    
            }
            bool dividableOnEight = sumDigits % 8 == 0;
            
            if (dividableOnEight && hasOneDigit) return true;
            else return false;
        }
    }
}
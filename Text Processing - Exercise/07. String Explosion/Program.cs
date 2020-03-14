using System;
using System.Collections.Generic;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] spliittedInput = text.Split(">",StringSplitOptions.RemoveEmptyEntries);

            string result = spliittedInput[0];
            int remainingPower = 0;
            for (int i = 1; i < spliittedInput.Length; i++)
            {
                result += ">";
                int power = int.Parse(spliittedInput[i][0].ToString()) + remainingPower;
                if(power > spliittedInput[i].Length)
                {
                    remainingPower = power - spliittedInput[i].Length;
                }
                else
                {
                    result += spliittedInput[i].Substring(power);
                }

            }
            Console.WriteLine(result);
        }
    }
}
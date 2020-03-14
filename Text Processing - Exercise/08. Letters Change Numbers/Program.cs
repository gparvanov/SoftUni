using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] {' ','\t' },StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string input = words[i];
                char firstSymbol = input[0];
                char lastSymbol = input[input.Length - 1];
                decimal digit = decimal.Parse(input.Substring(1, input.Length - 2));
                
                if (char.IsUpper(firstSymbol))
                {
                    digit /= firstSymbol - 'A' +1;
                }
                else digit *= firstSymbol - 'a' + 1;

                if(char.IsUpper(lastSymbol))
                {
                    digit -=  lastSymbol - 'A' + 1;
                }
                else digit += lastSymbol - 'a' + 1;

                totalSum += digit;
            }
            Console.WriteLine($"{totalSum.ToString("f2")}");
        }
    }
}
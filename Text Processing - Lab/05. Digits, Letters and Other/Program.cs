﻿using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string numbers = string.Empty;
            string letters = string.Empty;
            string anythingelse = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i])) numbers += text[i];
                else if (char.IsLetter(text[i])) letters += text[i];
                else anythingelse += text[i];
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(anythingelse);
        }
    }
}

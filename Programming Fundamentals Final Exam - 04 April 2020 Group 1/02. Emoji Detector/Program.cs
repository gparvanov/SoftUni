using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string regexWords = @"((\*\*|\:\:))(?<word>[A-Z][a-z]{2,})\1";
            string regexNumbers = @"(?<digit>\d+)";

            BigInteger threshold = 1;

            var dataNumbers = Regex.Matches(text, regexNumbers);

            if (dataNumbers.Count > 0)
            {
                foreach (Match digit in dataNumbers)
                {
                    string number = digit.Groups["digit"].Value;
                    foreach (var num in number)
                    {
                        int currentNum = int.Parse(num.ToString());                        
                        threshold *= currentNum;
                    }                    
                }
            }            
            Console.WriteLine($"Cool threshold: {threshold}");

            var dataEmojis = Regex.Matches(text, regexWords);

            Console.WriteLine($"{dataEmojis.Count} emojis found in the text. The cool ones are:");

            if (dataEmojis.Count > 0)
            {
                foreach  (Match emoji in dataEmojis)
                {
                    string word = emoji.Groups["word"].Value;                    
                    BigInteger sumAscii = 0;
                    foreach (var letter in word)
                    {
                        sumAscii += letter;
                    }                    
                    if (sumAscii >= threshold) Console.WriteLine($"{emoji.Value}");
                }
            }            
        }
    }
}
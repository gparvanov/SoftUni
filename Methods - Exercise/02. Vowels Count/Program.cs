using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string incomingText = Console.ReadLine();
            VowelsCount(incomingText.ToLower());
        }
        static void VowelsCount(string text)
        {
            int countVowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u' ) countVowels++;
            }
            Console.WriteLine(countVowels);
        }
    }
}
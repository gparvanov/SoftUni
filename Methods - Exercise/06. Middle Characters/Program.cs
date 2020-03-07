using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleCharacter(text);
        }

        static void PrintMiddleCharacter(string text)
        {
            string middleCharacter = "";
            
            int middleIndex = text.Length / 2;
            if (middleIndex == 0)
            {
                Console.WriteLine($"{text}");
                return;
            }
            if(text.Length % 2 == 0)
            {
                middleCharacter = text[middleIndex - 1].ToString() + text[middleIndex];
            }
            else
            {
                middleCharacter = text[middleIndex].ToString();
            }
            Console.WriteLine($"{middleCharacter}");
        }
    }
}

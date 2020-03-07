using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());

            int lettersSum = 0;

            for (int i = 0; i < letters; i++)
            {
                lettersSum += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {lettersSum}");
        }
    }
}

using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] words= Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                string tempElement = words[randomIndex];
                words[randomIndex] = words[i];
                words[i] = tempElement;
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();
            int messageLength = message.Length;
            string collectedChars = "";

            for (int i = 0; i < list.Count; i++)
            {
                string currentElement = list[i].ToString();
                int lengthOfElement = currentElement.Length;
                int elementIndex = 0;
                int elementSum = 0;
                for (int j = 0; j < lengthOfElement; j++)
                {
                    elementSum += currentElement[j] - '0';
                }
                if (elementSum >= messageLength) elementIndex = elementSum % lengthOfElement;
                else elementIndex = elementSum;                
                collectedChars += message[elementIndex];
                message = message.Remove(elementIndex, 1);
            }
            Console.WriteLine(collectedChars);
        }
    }
}
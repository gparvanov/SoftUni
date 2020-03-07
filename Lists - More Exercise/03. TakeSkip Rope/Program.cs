using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string incoming = Console.ReadLine();

            List<string> message = new List<string>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            string hidden = "";
            for (int i = 0; i < incoming.Length; i++)
            {
                if (incoming[i] - '0' >=0 && incoming[i] - '0' <= 9) numbers.Add(incoming[i] - '0');                    
                else message.Add(incoming[i].ToString());
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0) takeList.Add(numbers[i]);
                else skipList.Add(numbers[i]);
            }
            int skipped = 0;            
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];                
                String text = string.Join("", message).Remove(0, skipped);                
                hidden += string.Join("",text.Take(take));                
                skipped += skipList[i] + take;
            }
            Console.WriteLine(hidden);
        }
    }
}
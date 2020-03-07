using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = "";
            command = Console.ReadLine();
            while (command != "3:1")
            {
                if (command == "3:1") break;
                string[] inputCommands = command.Split().ToArray();
                if (inputCommands[0] == "merge") MergeList(input, int.Parse(inputCommands[1]), int.Parse(inputCommands[2]));
                else if(inputCommands[0] == "divide") DivideList(input, int.Parse(inputCommands[1]), int.Parse(inputCommands[2]));
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',input));
        }
        static void MergeList(List<string> l, int start,int end)
        {
            if (start < 0) start = 0;
            else if (start >= l.Count) start = l.Count -1;
            if (end < 0) end = 0;
            else if (end >= l.Count) end = l.Count -1;
            string mergedValues = "";
            for (int i = start; i <= end; i++)
            {
                mergedValues += l[i];                
            }
            l[start] = mergedValues;
            l.RemoveRange(start + 1, end - start);            
        }
        static void DivideList(List<string> l, int index, int parts)
        {
            if (index < 0) index = 0;
            else if (index >= l.Count) index = l.Count - 1;
            string elementToBeSplit = l[index];
            l.RemoveAt(index);
            bool longerLastElement = (elementToBeSplit.Length % parts != 0);
            int taken = 0;
            List<string> tempList = new List<string>();
            if (elementToBeSplit.Length % parts == 0)
            {
                for (int i = 0; i < parts; i++)
                {
                    tempList.Add(string.Join("",elementToBeSplit.Skip(taken).Take(elementToBeSplit.Length/parts)));                    
                    taken += elementToBeSplit.Length / parts;
                }
            }
            else
            {
                for (int i = 0; i < parts -1 ; i++)
                {
                    tempList.Add(string.Join("", elementToBeSplit.Skip(taken).Take(elementToBeSplit.Length / parts)));
                    taken += elementToBeSplit.Length / parts;
                }
                tempList.Add(string.Join("", elementToBeSplit.Skip(taken).Take(elementToBeSplit.Length - taken)));
            }
            l.InsertRange(index, tempList);
        }
    }
}
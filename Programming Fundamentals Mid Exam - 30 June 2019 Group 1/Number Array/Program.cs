using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = "";
            command = Console.ReadLine();
            while (command!="End")
            {
                string[] inputData = command.Split();
                if(inputData[0] == "Switch")
                {
                    if(int.Parse(inputData[1])>=0 && int.Parse(inputData[1]) <= numbers.Count -1 ) numbers[int.Parse(inputData[1])] *= -1;                    
                }
                else if ( inputData[0] == "Change")
                {
                    if (int.Parse(inputData[1]) >= 0 && int.Parse(inputData[1]) <= numbers.Count - 1) numbers[int.Parse(inputData[1])] = int.Parse(inputData[2]);
                }
                else if (inputData[0] == "Sum")
                {
                    int sum = 0;
                    if(inputData[1] == "Negative")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < 0) sum += numbers[i];
                        }
                    }
                    else if (inputData[1] == "Positive")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= 0) sum += numbers[i];
                        }
                    }
                    else if (inputData[1] == "All")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                    }
                    Console.WriteLine(sum);
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0) Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}

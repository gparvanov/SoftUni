using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string command = "";
            int maxOnes = 0;
            int bestStartIndex = -1;
            int bestSequenceSum = 0;
            string bestSequence = "";
            int sample = 0;
            int bestSample = 0;
            while (command!="Clone them!")
            {                
                command = Console.ReadLine();
                if (command == "Clone them!") break;

                int[] dna = command.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                int currentMaxOnes = 0;
                int prevDigit = dna[0];                
                int currentSum = 0;
                string currentSequence = "";
                int startIndex = 0;
                for (int i = 0; i < length; i++)
                {
                    if (dna[i] == 1) currentSum++;
                    currentSequence += dna[i] + " ";
                }
                for (int i = 0; i < length; i++)
                {                    
                    if (dna[i] == 1 && prevDigit == 1)
                    {
                        currentMaxOnes++;
                        startIndex = i - currentMaxOnes + 1;
                        prevDigit = 1;
                        if (currentMaxOnes > maxOnes)
                        {                            
                            maxOnes = currentMaxOnes;
                            bestSample = sample;
                            bestSequenceSum = currentSum;
                            bestSequence = currentSequence;
                            if (startIndex > bestStartIndex) bestStartIndex = startIndex;
                        }
                        else if ( currentMaxOnes == maxOnes && startIndex < bestStartIndex)
                        {
                            bestSample = sample;
                            bestSequenceSum = currentSum;
                            bestSequence = currentSequence;
                        }
                        else if (currentMaxOnes == maxOnes && startIndex == bestStartIndex && currentSum > bestSequenceSum)
                        {
                            bestSample = sample;
                            bestSequenceSum = currentSum;
                            bestSequence = currentSequence;
                        }
                    }  
                    else if ( dna[i] == 1 && prevDigit == 0)
                    {
                        if (currentMaxOnes == 0) currentMaxOnes++;                        
                        startIndex = i - currentMaxOnes + 1;
                        prevDigit = 1;
                    }
                    else 
                    {
                        prevDigit = 0;
                    }                    
                }                                
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{bestSequence}");
        }
    }
}

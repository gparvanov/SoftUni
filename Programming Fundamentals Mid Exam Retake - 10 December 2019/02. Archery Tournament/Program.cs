using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split("|").Select(int.Parse).ToList();
            int collectedPoints = 0;
            string command = "";
            command = Console.ReadLine();
            while(command !="Game over")
            {
                string[] inputData = command.Split().ToArray();
                if(inputData[0] == "Shoot")
                {
                    string[] secondaryCommand = inputData[1].Split("@").ToArray();
                    if(secondaryCommand[0] == "Left")
                    {
                        int startIndex = int.Parse(secondaryCommand[1]);
                        if (startIndex >= 0 && startIndex <= targets.Count -1)
                        {
                            int moves = int.Parse(secondaryCommand[2]);
                            int currentIndex = startIndex;
                            for (int i = 1; i <= moves; i++)
                            {
                                currentIndex--;
                                if (currentIndex < 0) currentIndex = targets.Count - 1;
                            }
                            if (targets[currentIndex] > 5)
                            {
                                collectedPoints += 5;
                                targets[currentIndex] -= 5;
                            }
                            else
                            {
                                collectedPoints += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }
                        }
                    }
                    else if ( secondaryCommand[0] == "Right")
                    {
                        int startIndex = int.Parse(secondaryCommand[1]);
                        if (startIndex >= 0 && startIndex <= targets.Count-1)
                        {
                            int moves = int.Parse(secondaryCommand[2]);
                            int currentIndex = startIndex;
                            for (int i = 1; i <= moves; i++)
                            {
                                currentIndex++;
                                if (currentIndex >= targets.Count) currentIndex = 0;
                            }
                            if (targets[currentIndex] > 5)
                            {
                                collectedPoints += 5;
                                targets[currentIndex] -= 5;
                            }
                            else
                            {
                                collectedPoints += targets[currentIndex];
                                targets[currentIndex] = 0;
                            }
                        }
                    }
                }
                else if ( inputData[0] == "Reverse")
                {
                    targets.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ",targets));
            Console.WriteLine($"Iskren finished the archery tournament with {collectedPoints} points!");
        }
    }
}
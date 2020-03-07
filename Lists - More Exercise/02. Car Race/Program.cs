using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> raceTimes = Console.ReadLine().Split().Select(double.Parse).ToList();
            double timePlayer1 = 0;
            double timePlayer2 = 0;
            for (int i = 0; i < raceTimes.Count / 2; i++)
            {
                if (raceTimes[i] != 0) timePlayer1 += raceTimes[i];
                else timePlayer1 *= 0.8;
            }
            for (int i = raceTimes.Count - 1; i > raceTimes.Count / 2; i--)
            {
                if (raceTimes[i] != 0) timePlayer2 += raceTimes[i];
                else timePlayer2 *= 0.8;
            }            
            bool winnerIsOne = timePlayer1 < timePlayer2;
            if (winnerIsOne) Console.WriteLine($"The winner is left with total time: {Math.Round(timePlayer1,2)}");
            else Console.WriteLine($"The winner is right with total time: {Math.Round(timePlayer2,2)}");
        }
    }
}
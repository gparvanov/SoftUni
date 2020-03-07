using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowBalls = int.Parse(Console.ReadLine());
            BigInteger bestBallSnow = 0;
            BigInteger bestBallTime = 0;
            BigInteger bestBallQuality = 0;
            BigInteger bestBallValue = -1; 

            for (int i = 1; i <= numberOfSnowBalls; i++)
            {
                BigInteger ballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger ballTime = BigInteger.Parse(Console.ReadLine());
                int ballQuality = int.Parse(Console.ReadLine());

                BigInteger currentBallValue = 0;

                if (ballTime != 0) currentBallValue = BigInteger.Pow(ballSnow / ballTime, ballQuality);
                else currentBallValue = 0;           

                if(currentBallValue >= bestBallValue)
                {
                    bestBallSnow = ballSnow;
                    bestBallTime = ballTime;
                    bestBallQuality = ballQuality;
                    bestBallValue = currentBallValue;
                }                
            }
            if(bestBallValue>=long.MinValue) Console.WriteLine($"{bestBallSnow} : {bestBallTime} = {bestBallValue} ({bestBallQuality})");            
        }
    }
}
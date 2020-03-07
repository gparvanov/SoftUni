using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetsDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int leftPower = pokePower;
            int reachedTargets = 0;

            while (leftPower >= pokeTargetsDistance)
            {
                leftPower -= pokeTargetsDistance;
                if(leftPower * 2 == pokePower)
                {
                    if (exhaustionFactor > 0 && leftPower / exhaustionFactor > 0) leftPower /= exhaustionFactor;                    
                }
                reachedTargets++;                
            }
            Console.WriteLine($"{leftPower}");
            Console.WriteLine($"{reachedTargets}");
        }
    }
}
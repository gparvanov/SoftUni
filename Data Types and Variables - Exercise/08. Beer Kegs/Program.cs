using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double biggestKegVolume = double.MinValue;
            string biggestKegName = "";


            for (int i = 1; i <= numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * (Math.Pow(kegRadius, 2) * height);

                if(currentKegVolume >= biggestKegVolume)
                {
                    biggestKegVolume = currentKegVolume;
                    biggestKegName = model;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}

using System;

namespace Giftbox_Coverage
{
    class Program
    {
        static void Main()
        {
            double sideOfTheBox = double.Parse(Console.ReadLine());
            double boxArea = sideOfTheBox * sideOfTheBox * 6;
            int sheets = int.Parse(Console.ReadLine());
            double singleSheetArea = double.Parse(Console.ReadLine());            
            double areaThatCanBeCovered = (singleSheetArea * sheets - ((sheets / 3) * singleSheetArea * 0.75))/boxArea * 100 ;
            Console.WriteLine($"You can cover {areaThatCanBeCovered:F2}% of the box.");
        }
    }
}
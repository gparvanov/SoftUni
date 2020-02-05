using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            float headSetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int crashedHeadset = lostGamesCount / 2; 
            int crashedMouse = lostGamesCount / 3;
            int crashedKeyboard = lostGamesCount / 6;
            int crashedDisplay = lostGamesCount / 12;


            float headsetExpences = crashedHeadset * headSetPrice;
            float mouseExpences = crashedMouse * mousePrice;
            float keyboardExpences = crashedKeyboard * keyboardPrice;
            float displayExpences = crashedDisplay * displayPrice;

            float totalExpences = headsetExpences + mouseExpences + keyboardExpences + displayExpences;

            Console.WriteLine($"Rage expenses: {totalExpences:F2} lv.");

        }
    }
}

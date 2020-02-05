using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());

            float spentMoney = 0;

            string command = "";

            while(command!="Game Time")
            {
                command = Console.ReadLine();
                float gamePrice = 0;
                if (command == "Game Time") break;
                else if (command == "OutFall 4") gamePrice = 39.99F;
                else if (command == "CS: OG") gamePrice = 15.99F;
                else if (command == "Zplinter Zell") gamePrice = 19.99F;
                else if (command == "Honored 2") gamePrice = 59.99F;
                else if (command == "RoverWatch") gamePrice = 29.99F;
                else if (command == "RoverWatch Origins Edition") gamePrice = 39.99F;
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }

                if (budget >= gamePrice)
                {
                    budget -= gamePrice;
                    spentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                if (budget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${budget:F2}");
        }
    }
}

using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyToCollect = 0;

            string command = Console.ReadLine();

            while (command != "Start" && command !="End")
            {
                double coin  = double.Parse(command);

                if(coin != 0.1 && coin != 0.2 && coin != 0.5 && coin !=1.0 && coin != 2.0)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                else
                {
                    moneyToCollect += coin;
                }
                command = Console.ReadLine();
            }
            double leftMoney = moneyToCollect;

            string product = "";
            double purchaseSum = 0;
            while (product != "End")
            {
                product = Console.ReadLine();
                if (product == "End") break;
                else if (product == "Nuts") purchaseSum = 2.0;
                else if (product == "Water") purchaseSum = 0.7;
                else if (product == "Crisps") purchaseSum = 1.5;
                else if (product == "Soda") purchaseSum = 0.8;
                else if (product == "Coke") purchaseSum = 1.0;
                else 
                {                  
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (leftMoney >= purchaseSum)
                {
                    leftMoney -= purchaseSum;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    if(leftMoney <= 0) break;
                }
                else Console.WriteLine("Sorry, not enough money");
            }
            Console.WriteLine($"Change: {leftMoney:F2}");
        }
    }
}

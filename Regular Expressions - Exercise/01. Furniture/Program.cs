using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string purchase = Console.ReadLine();
            double totalSpentMoney = 0;
            var products = new List<string>();
            while(purchase != "Purchase")
            {
                string regex = @">>(?<product>\w+)<<(?<price>[0-9]+([.][0-9]+)?)!(?<quantity>\d+)";

                var data = Regex.Matches(purchase, regex);

                foreach (Match item in data)
                {
                    var product = item.Groups["product"].Value;
                    double price = double.Parse(item.Groups["price"].Value);
                    int quantity = int.Parse(item.Groups["quantity"].Value);
                    totalSpentMoney += price * quantity;
                    products.Add(product);
                }
                purchase = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{products[i]}");
            }
            Console.WriteLine($"Total money spend: {totalSpentMoney:f2}");
        }
    }
}

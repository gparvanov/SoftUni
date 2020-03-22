using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();

            double totalIncomes = 0;

            while(order!="end of shift")
            {
                string customerName = string.Empty;
                string product = string.Empty;                

                string regex = @"[^|$%.\s]*%(?<name>[A-Z][a-z]+)%[^|$%.]*<\W*(?<product>\w+)\W*>[^|$%.]*(\|)\D*(?<quantity>\d+)\D*(\|)\D*(?<price>[0-9]+([.][0-9]+)?)\D*(\$)";

                var data = Regex.Matches(order, regex);
                if (data.Count > 0) {
                    foreach (Match item in data)
                    {
                        customerName = item.Groups["name"].Value;
                        product = item.Groups["product"].Value;
                        int count = int.Parse(item.Groups["quantity"].Value);
                        double price = double.Parse(item.Groups["price"].Value);
                        totalIncomes += count * price;
                        Console.WriteLine($"{customerName}: {product} - {count * price:F2}");
                    }                    
                }
                order = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncomes:f2}");
        }
    }
}
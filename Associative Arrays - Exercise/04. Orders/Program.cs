using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();
            string input = "";
            input = Console.ReadLine();
            while (input != "buy")
            {
                string[] values = input.Split().ToArray();
                if (!products.ContainsKey(values[0]))
                {
                    products[values[0]] = new double[2];
                    products[values[0]][0] = double.Parse(values[1]);
                    products[values[0]][1] = double.Parse(values[2]);
                }
                else
                {
                    products[values[0]][0] = double.Parse(values[1]);
                    products[values[0]][1] += double.Parse(values[2]);
                }
                input =Console.ReadLine();
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):F2}");
            }
        }
    }
}
using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[] pascalTriangle = new string[rows];
            int val = 1;
            for (int i = 0; i < rows; i++)
            {
                string rowString = "";
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        val = 1;
                    else
                        val = val * (i - j + 1) / j;
                    rowString += val + " ";
                }
                pascalTriangle[i] = rowString;                
            }
            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                Console.WriteLine($"{pascalTriangle[i]}");
            }
        }
    }
}

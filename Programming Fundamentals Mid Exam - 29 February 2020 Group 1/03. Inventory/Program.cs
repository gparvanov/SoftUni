using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine().Split().ToList();

            int commands = int.Parse(Console.ReadLine());

            for (int i = 1; i <= commands; i++)
            {
                string input = Console.ReadLine();

                string[] inputData = input.Split().ToArray();

                if(inputData[0] == "Include")
                {
                    shops.Add(inputData[1]);
                }
                else if ( inputData[0] == "Visit")
                {
                    int shopsToBeVisited = int.Parse(inputData[2]);
                    if(inputData[1] == "first")
                    {
                        if (shops.Count >= int.Parse(inputData[2]))
                        {
                            for (int j = 1; j <= shopsToBeVisited ; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                    }
                    else if ( inputData[1] == "last")
                    {
                        if (shops.Count >= int.Parse(inputData[2]))
                        {
                            int times = 0;
                            for (int j = shops.Count -1 ; j >= 0; j--)
                            {
                                times++;
                                shops.RemoveAt(j);
                                if (times >= shopsToBeVisited) break;
                            }
                        }
                    }
                }
                else if ( inputData[0] == "Prefer")
                {
                    int shop1 = int.Parse(inputData[1]);
                    int shop2 = int.Parse(inputData[2]);

                    if(shop1 >=0 && shop1 <=shops.Count-1 && shop2 >=0 && shop2 <= shops.Count - 1)
                    {
                        string tempname = shops[shop1];
                        shops[shop1] = shops[shop2];
                        shops[shop2] = tempname;
                    }
                }
                else if ( inputData[0] == "Place")
                {
                    if(int.Parse(inputData[2]) >=0 && int.Parse(inputData[2]) <= shops.Count - 1)
                    {
                        shops.Insert(int.Parse(inputData[2])+1, inputData[1]);
                    }
                }
            }
            Console.WriteLine($"Shops left:");
            Console.WriteLine(string.Join(" ",shops));

        }        
    }
}
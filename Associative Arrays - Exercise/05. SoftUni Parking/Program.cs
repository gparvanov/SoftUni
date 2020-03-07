using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new Dictionary<string, string>();
            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                string[] inputData = Console.ReadLine().Split();
                string username = inputData[1];                
                if (inputData[0] == "register")
                {
                    string license = inputData[2];
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                    }
                    else
                    {
                        parking[username] = license;
                        Console.WriteLine($"{username} registered {license} successfully");
                    }
                }
                else if (inputData[0] == "unregister")
                {
                    if(parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{ username} unregistered successfully");
                    }
                    else Console.WriteLine($"ERROR: user {username} not found");
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
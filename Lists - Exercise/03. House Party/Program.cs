using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int numberOfGuests = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfGuests; i++)
            {
                string[] guestCommand = Console.ReadLine().Split().ToArray();
                if (guestCommand[2] == "going!")
                {
                    if(guests.Contains(guestCommand[0])) Console.WriteLine($"{guestCommand[0]} is already in the list!");
                    else guests.Add(guestCommand[0]);
                }
                else if (guestCommand[2] == "not") 
                {
                    if (guests.Contains(guestCommand[0])) guests.Remove(guestCommand[0]);
                    else Console.WriteLine($"{guestCommand[0]} is not in the list!");
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);   
            }
        }
    }
}
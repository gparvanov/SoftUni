using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":",StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newDeck = new List<string>();
            string command = "";
            command = Console.ReadLine();
            while (command != "Ready")
            {
                string[] inputCommands = command.Split();
                if (inputCommands[0] == "Add")
                {
                    if (cards.Contains(inputCommands[1])) newDeck.Add(inputCommands[1]);
                    else Console.WriteLine($"Card not found.");
                }
                else if (inputCommands[0] == "Insert")
                {
                    if (int.Parse(inputCommands[2]) >= 0 && int.Parse(inputCommands[2]) < newDeck.Count){

                        if (cards.Contains(inputCommands[1])) newDeck.Insert(int.Parse(inputCommands[2]), inputCommands[1]);
                        else Console.WriteLine($"Error!");
                    }
                    else Console.WriteLine($"Error!");
                }
                else if (inputCommands[0] == "Remove")
                {
                    if (newDeck.Contains(inputCommands[1])) newDeck.Remove(inputCommands[1]);
                    else Console.WriteLine($"Card not found.");
                }
                else if (inputCommands[0] == "Swap")
                {
                    int indexCard1 = newDeck.IndexOf(inputCommands[1]);
                    int indexCard2 = newDeck.IndexOf(inputCommands[2]);
                    string tempCard = newDeck[indexCard1];
                    newDeck[indexCard1] = newDeck[indexCard2];
                    newDeck[indexCard2] = tempCard;
                }
                else if (inputCommands[0] == "Shuffle" && inputCommands[1] == "deck")
                {
                    newDeck.Reverse();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
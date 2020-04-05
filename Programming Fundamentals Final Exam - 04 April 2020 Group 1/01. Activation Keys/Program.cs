using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder activationKey = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while(command != "Generate")
            {
                string[] commands = command.Split(">>>");

                if(commands[0] == "Contains")
                {
                    string searchString = commands[1].Trim();
                    if (activationKey.ToString().Contains(searchString)) Console.WriteLine($"{activationKey} contains {searchString}");
                    else Console.WriteLine("Substring not found!");
                }
                else if ( commands[0] == "Flip")
                {
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    string textToBeFlipped = activationKey.ToString().Substring(startIndex, endIndex - startIndex);                    
                    if (commands[1] == "Upper")
                    {
                        textToBeFlipped = textToBeFlipped.ToUpper();
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);                        
                        activationKey = new StringBuilder ( activationKey.Insert(startIndex, textToBeFlipped).ToString());
                    }
                    else if ( commands[1] == "Lower")
                    {
                        textToBeFlipped = textToBeFlipped.ToLower();
                        activationKey.Remove(startIndex, endIndex - startIndex);                        
                        activationKey.Insert(startIndex, textToBeFlipped);
                    }
                    Console.WriteLine(activationKey);

                }
                else if ( commands[0] == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    activationKey = new StringBuilder(activationKey.Remove(startIndex, endIndex - startIndex).ToString());
                    Console.WriteLine(activationKey);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
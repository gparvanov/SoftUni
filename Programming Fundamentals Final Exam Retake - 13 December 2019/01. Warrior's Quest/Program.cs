using System;
using System.Text;

namespace _01._Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder skill = new StringBuilder(Console.ReadLine().Trim());
            string command = Console.ReadLine();

            while(command!= "For Azeroth")
            {
                string[] inputData = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (inputData[0] == "GladiatorStance")
                {
                    skill = new StringBuilder(skill.ToString().ToUpper());
                    Console.WriteLine(skill.ToString());
                }
                else if (inputData[0] == "DefensiveStance")
                {
                    skill = new StringBuilder(skill.ToString().ToLower());
                    Console.WriteLine(skill.ToString());
                }
                else if (inputData[0] == "Dispel")
                {
                    int index = int.Parse(inputData[1]);
                    char letter = char.Parse(inputData[2]);
                    if (index >= 0 && index < skill.Length)
                    {
                        skill.Remove(index, 1);
                        skill.Insert(index, letter);
                        Console.WriteLine("Success!");
                    }
                    else Console.WriteLine("Dispel too weak.");
                }
                else if (inputData[0] == "Target")
                {
                    if (inputData[1] == "Change")
                    {
                        string oldString = inputData[2];
                        string newString = inputData[3];
                        skill.Replace(oldString, newString);
                        Console.WriteLine(skill.ToString());
                    }
                    else if (inputData[1] == "Remove")
                    {
                        string trimString = inputData[2];
                        skill.Replace(trimString, null);
                        Console.WriteLine(skill.ToString());
                    }
                }
                else Console.WriteLine("Command doesn't exist!");
                command = Console.ReadLine();
            }
        }
    }
}
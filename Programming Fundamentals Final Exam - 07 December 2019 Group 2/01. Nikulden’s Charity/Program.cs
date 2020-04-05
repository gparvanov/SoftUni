using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] inputData = command.Split(" ");
                if (inputData[0] == "Replace")
                {
                    char currentChar = char.Parse(inputData[1]);
                    char newChat = char.Parse(inputData[2]);
                    for (int i = 0; i < text.Length; i++)
                    {
                        if(text[i] == currentChar)
                        {
                            text.Remove(i, 1);
                            text.Insert(i, newChat);
                        }
                    }
                    Console.WriteLine(text);
                    
                }
                else if (inputData[0] == "Cut")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int endIndex = int.Parse(inputData[2]);
                    if(startIndex >= 0 && endIndex>=0 && startIndex < text.Length && endIndex< text.Length)
                    {
                        text.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(text);
                    }
                    else Console.WriteLine("Invalid indexes!");
                }
                else if (inputData[0] == "Make")
                {
                    if (inputData[1] == "Upper") text = new StringBuilder(text.ToString().ToUpper());
                    else if ( inputData[1] == "Lower") text = new StringBuilder(text.ToString().ToLower());
                    Console.WriteLine(text);
                }
                else if (inputData[0] == "Check")
                {
                    if (text.ToString().Contains(inputData[1])) Console.WriteLine($"Message contains {inputData[1]}");
                    else Console.WriteLine($"Message doesn't contain {inputData[1]}");
                }
                else if (inputData[0] == "Sum")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int endIndex = int.Parse(inputData[2]);
                    if (startIndex >= 0 && endIndex >= 0 && startIndex < text.Length && endIndex < text.Length)
                    {
                        string currentString = text.ToString();
                        int sum = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += currentString[i];
                        }
                        Console.WriteLine(sum);
                    }
                    else Console.WriteLine("Invalid indexes!");
                }
                command = Console.ReadLine();
            }
        }
    }
}
using System;
using System.Text;

namespace _01._String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] inputData = command.Split(" ");

                if (inputData[0] == "Change")
                {
                    char oldChar = char.Parse(inputData[1]);
                    char newChar = char.Parse(inputData[2]);
                    text = new StringBuilder(text.Replace(oldChar, newChar).ToString());
                    Console.WriteLine(text);
                }
                else if (inputData[0] == "Includes")
                {
                    string findString = inputData[1];
                    if (text.ToString().Contains(findString)) Console.WriteLine("True");
                    else Console.WriteLine("False");
                }
                else if (inputData[0] == "End")
                {
                    string endString = inputData[1];
                    if (text.ToString().EndsWith(endString)) Console.WriteLine("True");
                    else Console.WriteLine("False");
                }
                else if (inputData[0] == "Uppercase")
                {
                    text = new StringBuilder(text.ToString().ToUpper());
                    Console.WriteLine(text);
                }
                else if (inputData[0] == "FindIndex")
                {
                    char symbolToFind = char.Parse(inputData[1]);
                    int lastIndex = text.ToString().IndexOf(symbolToFind);
                    Console.WriteLine(lastIndex);
                }
                else if (inputData[0] == "Cut")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int chars = int.Parse(inputData[2]);
                    text = new StringBuilder(text.ToString().Substring(startIndex,chars));                    
                    Console.WriteLine(text);
                }
                command = Console.ReadLine();
            }
        }
    }
}
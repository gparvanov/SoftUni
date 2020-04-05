using System;
using System.Text;

namespace _01._String_Manipulator___Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());

            string command = Console.ReadLine();

            while(command != "End")
            {
                string[] inputData = command.Split(" ");

                if(inputData[0] == "Translate")
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
                else if (inputData[0] == "Start")
                {
                    string startString = inputData[1];
                    if (text.ToString().IndexOf(startString) == 0 ) Console.WriteLine("True");
                    else Console.WriteLine("False");
                }
                else if (inputData[0] == "Lowercase")
                {
                    text = new StringBuilder(text.ToString().ToLower());
                    Console.WriteLine(text);
                }
                else if (inputData[0] == "FindIndex")
                {
                    char symbolToFind = char.Parse(inputData[1]);
                    int lastIndex = text.ToString().LastIndexOf(symbolToFind);
                    Console.WriteLine(lastIndex);
                }
                else if (inputData[0] == "Remove")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int numberChars = int.Parse(inputData[2]);
                    text.Remove(startIndex, numberChars);
                    Console.WriteLine(text);
                }
                command = Console.ReadLine();
            }
        }
    }
}
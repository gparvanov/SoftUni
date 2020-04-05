using System;
using System.Linq;
using System.Text;

namespace _01._Username
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while( command != "Sign up")
            {
                string[] inputData = command.Split(" ");

                if(inputData[0] == "Case")
                {
                    if (inputData[1] == "lower") name = new StringBuilder(name.ToString().ToLower());
                    else if (inputData[1] == "upper") name = new StringBuilder(name.ToString().ToUpper());
                    Console.WriteLine(name);
                }
                else if ( inputData[0] == "Reverse")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int endIndex = int.Parse(inputData[2]);
                    if (startIndex >= 0 && startIndex < name.ToString().Length && endIndex < name.ToString().Length)
                    {
                        var toPrint = name.ToString().Substring(startIndex, endIndex - startIndex + 1).ToList();
                        toPrint.Reverse();
                        Console.WriteLine(string.Join("", toPrint));
                    }
                }
                else if ( inputData[0] == "Cut")
                {
                    string toCut = inputData[1];
                    if (name.ToString().Contains(toCut))
                    {
                        name.Replace(toCut, "");
                        Console.WriteLine(name);
                    }
                    else Console.WriteLine($"The word {name} doesn't contain {toCut}.");
                }
                else if (inputData[0] == "Replace")
                {
                    char toReplace = char.Parse(inputData[1]);
                    while(name.ToString().IndexOf(toReplace) != -1)
                    {
                        name = new StringBuilder(name.Replace(toReplace, '*').ToString());
                    }
                    Console.WriteLine(name);
                }                
                else if ( inputData[0] == "Check")
                {
                    char validChar = char.Parse(inputData[1]);
                    if (name.ToString().Contains(validChar)) Console.WriteLine("Valid");
                    else Console.WriteLine($"Your username must contain {validChar}.");
                }
                command = Console.ReadLine();
            }
        }
    }
}
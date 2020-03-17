using System;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);            
            string command = Console.ReadLine();
            while(command != "find")
            {
                int keyStartIndex = 0;
                string resultString = string.Empty;
                for (int i = 0; i < command.Length; i++)
                {
                    if (keyStartIndex == numbers.Length) keyStartIndex = 0;
                    resultString += (char)(command[i] - int.Parse(numbers[keyStartIndex]));
                    keyStartIndex++;    
                }                
                int typeStart = resultString.IndexOf('&');
                int typeEnd = resultString.LastIndexOf('&');
                string type = resultString.Substring(typeStart + 1, typeEnd - typeStart - 1);
                int coordinateStart = resultString.IndexOf('<');
                int coordinateEnd = resultString.IndexOf('>');
                string coordinates = resultString.Substring(coordinateStart + 1, coordinateEnd - coordinateStart - 1);
                Console.WriteLine($"Found {type} at {coordinates}");
                command = Console.ReadLine();
            }
        }
    }
}
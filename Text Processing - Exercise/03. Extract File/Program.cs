using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split(".");

            string extension = path[1];

            string[] file = path[0].Split("\\");

            string fileName = file[file.Length - 1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
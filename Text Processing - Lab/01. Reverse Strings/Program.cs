using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string text = string.Empty;
                for (int i = command.Length-1; i >=0 ; i--)
                {
                    text += command[i];
                }
                Console.WriteLine($"{command} = {text}");
                command = Console.ReadLine();
            }
        }
    }
}

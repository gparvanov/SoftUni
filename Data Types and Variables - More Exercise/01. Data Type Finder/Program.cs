using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = "";
            while (entry != "END")
            {
                entry = Console.ReadLine();
                if (entry == "END") break;
                if (Int32.TryParse(entry, out _))
                {
                    Console.WriteLine($"{entry} is integer type");
                }
                else if (double.TryParse(entry, out _))
                {
                    Console.WriteLine($"{entry} is floating point type");
                }
                else if (bool.TryParse(entry, out _))
                {
                    Console.WriteLine($"{entry} is boolean type");
                }
                else if (char.TryParse(entry, out _))
                {
                    Console.WriteLine($"{entry} is character type");
                }
                else
                {
                    Console.WriteLine($"{entry} is string type");
                }
            }
        }
    }
}

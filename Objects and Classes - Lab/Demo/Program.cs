using System;
using System.Globalization;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new { Day = 22, Month = 6, Year = 1990 };

            Cat cat = new Cat();
            cat.Eat();

            Console.WriteLine(cat.Fat);
        }
    }
}

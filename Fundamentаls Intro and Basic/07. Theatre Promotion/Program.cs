using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayName = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if(age> 64 && age<=122)
            {
                if (dayName == "weekday") price = 12;
                else if (dayName == "weekend") price = 15;
                else if (dayName == "holiday") price = 10;
                Console.WriteLine($"{price}$");
            }
            else if (age > 18 && age <=64)
            {
                if (dayName == "weekday") price = 18;
                else if (dayName == "weekend") price = 20;
                else if (dayName == "holiday") price = 12;
                Console.WriteLine($"{price}$");
            }
            else if ( age >=0 && age <=18)
            {
                if (dayName == "weekday") price = 12;
                else if (dayName == "weekend") price = 15;
                else if (dayName == "holiday") price = 5;
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }            
        }
    }
}

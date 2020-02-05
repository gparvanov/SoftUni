using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine().ToLower();
            string dayOfTheWeek = Console.ReadLine().ToLower();

            decimal singlePricePerPerson = 0;

            if (typeOfTheGroup == "students")
            {
                if (dayOfTheWeek=="friday") singlePricePerPerson = 8.45m;
                else if (dayOfTheWeek == "saturday") singlePricePerPerson = 9.8m;
                else if (dayOfTheWeek == "sunday") singlePricePerPerson = 10.46m;
                if (groupCount >= 30) singlePricePerPerson *= 0.85m;                
            }
            else if (typeOfTheGroup == "business")
            {
                if (dayOfTheWeek == "friday") singlePricePerPerson = 10.9m;
                else if (dayOfTheWeek == "saturday") singlePricePerPerson = 15.6m;
                else if (dayOfTheWeek == "sunday") singlePricePerPerson = 16m;
                if (groupCount >= 100) groupCount-=10;
            }
            else 
            {
                if (dayOfTheWeek == "friday") singlePricePerPerson = 15m;
                else if (dayOfTheWeek == "saturday") singlePricePerPerson = 20m;
                else if (dayOfTheWeek == "sunday") singlePricePerPerson = 22.5m;
                if (groupCount >= 10 && groupCount<=20) singlePricePerPerson *= 0.95m;
            }
            decimal totalPrice = groupCount * singlePricePerPerson;

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}

using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string stringToPrint = "";
            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int digits = 0;
                if (number / 1000 > 0) digits = 4;
                else if (number/100 >0) digits = 3;
                else if (number / 10 > 0) digits = 2;
                else digits = 1;

                int maindigit = number % 10;
                int offsett = (maindigit - 2) * 3;
                if (maindigit == 8 || maindigit == 9) offsett += 1;

                int letterIndex = offsett + digits - 1;

                int letterToPrint = 'a' + letterIndex;

                if (number == 1) stringToPrint += "";
                else if (number == 0) stringToPrint += " ";
                else stringToPrint += ((char)letterToPrint);                
            }
            Console.WriteLine(stringToPrint);
        }
    }
}

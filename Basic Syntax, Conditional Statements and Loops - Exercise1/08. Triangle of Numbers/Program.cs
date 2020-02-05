using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= number; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(rows+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

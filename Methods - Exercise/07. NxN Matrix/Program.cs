using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrix = int.Parse(Console.ReadLine());

            DrawMatrix(matrix);
        }

        static void DrawMatrix(int matrix)
        {
            for (int rows = 0; rows < matrix; rows++)
            {

                for (int columns = 0; columns < matrix; columns++)
                {
                    Console.Write($"{matrix} ");
                }
                Console.WriteLine();
            }
        }
    }
}

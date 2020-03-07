using System;
using System.Linq; 

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());

            int[] names = new int[numberOfStrings];

            for (int i = 0; i < names.Length; i++)
            {
                string name = Console.ReadLine();
                int nameSum = 0;

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'a' || name[j] == 'A' ||
                       name[j] == 'e' || name[j] == 'E' ||
                       name[j] == 'i' || name[j] == 'I' ||
                       name[j] == 'o' || name[j] == 'O' ||
                       name[j] == 'u' || name[j] == 'U')
                    {
                        nameSum += name[j] * name.Length;
                    }
                    else nameSum += name[j] / name.Length;
                }
                names[i] = nameSum;
            }
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}

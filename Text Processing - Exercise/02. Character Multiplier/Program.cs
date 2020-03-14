using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string string1 = strings[0];
            string string2 = strings[1];
            int result = 0;       
            while(string1.Length != 0 || string2.Length != 0)
            {
                int multiplier1 = 1;
                int multiplier2 = 1;
                if (string1.Length > 0)
                {
                    multiplier1 = string1[0];
                    string1 = string1.Substring(1);
                }
                if (string2.Length > 0)
                {
                    multiplier2 = string2[0];
                    string2 = string2.Substring(1);
                }
                result += multiplier1 * multiplier2;                
            }
            Console.WriteLine(result);
        }
    }
}
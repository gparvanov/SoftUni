using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string data = Console.ReadLine();
            DataTypeAction(dataType, data);                                             
        }
        static void DataTypeAction(string type,string data)
        {
            if(type == "int")
            {
                int number = int.Parse(data);
                Console.WriteLine($"{number * 2}");
            }
            else if (type == "real")
            {
                double number = double.Parse(data);
                Console.WriteLine($"{(number * 1.5):F2}");
            }
            else Console.WriteLine($"${data}$");            
        }
    }
}
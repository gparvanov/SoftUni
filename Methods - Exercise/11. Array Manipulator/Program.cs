using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            string command = Console.ReadLine();
            if (command == "end")
            {
                Console.WriteLine("[" + string.Join(", ", array) + "]");
                return;
            }
            while (command != "end")
            {
                string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);
                    if (index < 0 || index >= array.Length) Console.WriteLine("Invalid index");
                    else
                    {
                        int[] tempArray = array;
                        array = ExchangeArray(index, array).ToArray();
                    }
                }
                else if (commands[0] == "max" && commands[1] == "odd") ReturnMaxOdd(array);
                else if (commands[0] == "max" && commands[1] == "even") ReturnMaxEven(array);
                else if (commands[0] == "min" && commands[1] == "odd") ReturnMinOdd(array);
                else if (commands[0] == "min" && commands[1] == "even") ReturnMinEven(array);
                else if (commands[0] == "first" && commands[2] == "odd") ReturnFirstNOdd(array, int.Parse(commands[1]));
                else if (commands[0] == "first" && commands[2] == "even") ReturnFirstNEven(array, int.Parse(commands[1]));
                else if (commands[0] == "last" && commands[2] == "odd") ReturnLastNOdd(array, int.Parse(commands[1]));
                else if (commands[0] == "last" && commands[2] == "even") ReturnLastNEven(array, int.Parse(commands[1]));
                command = Console.ReadLine();
                if(command == "end")
                {                    
                    Console.WriteLine("["+string.Join(", ", array)+"]");
                    return;
                }
            }
        }
        static int[] ExchangeArray(long ind , int[] a)
        {
            int[] tempArray = new int[a.Length];
            int indexA = 0;
            long indexB = a.Length - ind -1 ;
            for (long i = ind+1; i < a.Length; i++)
            {
                tempArray[indexA] = a[i];
                indexA++;
            }
            for (int j = 0; j <= ind; j++)
            {
                tempArray[indexB] = a[j];
                indexB++;
            }
            a = tempArray.ToArray();
            return a;
        }
        static void ReturnMaxOdd(int[] a)
        {
            int maxOddIndex = 0;
            int maxOddElement = int.MinValue;
            bool elementFound = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0 && a[i] >= maxOddElement)
                {
                    maxOddElement = a[i];
                    maxOddIndex = i;
                    elementFound = true;
                }
            }
            if (elementFound) Console.WriteLine(maxOddIndex);
            else Console.WriteLine("No matches");
        }
        static void ReturnMaxEven(int[] a)
        {
            int maxEvenIndex = 0;
            int maxEvenElement = int.MinValue;
            bool elementFound = false;
            for (int i = 0; i < a.Length; i ++)
            {
                if (a[i] % 2 == 0 && a[i]>= maxEvenElement)
                {
                    maxEvenElement = a[i];
                    maxEvenIndex = i;
                    elementFound = true;
                }
            }
            if(elementFound) Console.WriteLine(maxEvenIndex);
            else Console.WriteLine("No matches");
        }
        static void ReturnMinOdd(int[] a)
        {
            int minOddIndex = 0;
            int minOddElement = int.MaxValue;
            bool elementFound = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0 && a[i] <= minOddElement)
                {
                    minOddElement = a[i];
                    minOddIndex = i;
                    elementFound = true;
                }
            }
            if (elementFound) Console.WriteLine(minOddIndex);
            else Console.WriteLine("No matches");
        }
        static void ReturnMinEven(int[] a)
        {
            int minEvenIndex = 0;
            int minEvenElement = int.MaxValue;
            bool elementFound = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] <= minEvenElement)
                {
                    minEvenElement = a[i];
                    minEvenIndex = i;
                    elementFound = true;
                }
            }
            if (elementFound) Console.WriteLine(minEvenIndex);
            else Console.WriteLine("No matches");
        }
        static void ReturnFirstNOdd(int[] a, int n)
        {
            if (n > a.Length) Console.WriteLine("Invalid count");
            else
            {
                string found = "";
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        count++;
                        found += a[i] + " ";
                        if (count >= n) break;
                    }
                }
                if (count == 0) Console.WriteLine("[]");
                else
                {
                    int[] tempArray = found.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
                   
                }
            }
        }
        static void ReturnFirstNEven(int[] a, int n)
        {
            if (n > a.Length) Console.WriteLine("Invalid count");
            else
            {
                string found = "";
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i] % 2 == 0)
                    {
                        count++;
                        found += a[i] + " ";
                        if (count >= n) break;
                    }
                }
                if (count == 0) Console.WriteLine("[]");
                else
                {
                    int[] tempArray = found.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");                    
                }
            }
        }
        static void ReturnLastNOdd(int[] a, int n)
        {
            if (n > a.Length) Console.WriteLine("Invalid count");
            else
            {
                string found = "";
                int count = 0;
                for (int i = a.Length-1; i >=0; i--)
                {
                    if (a[i] % 2 != 0)
                    {
                        count++;
                        found += a[i] + " ";
                        if (count >= n) break;
                    }
                }
                if (count == 0) Console.WriteLine("[]");
                else
                {
                    int[] tempArray = found.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Array.Reverse(tempArray);
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");

                }
            }
        }
        static void ReturnLastNEven(int[] a, int n)
        {
            if (n > a.Length) Console.WriteLine("Invalid count");
            else
            {
                string found = "";
                int count = 0;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (a[i] % 2 == 0)
                    {
                        count++;
                        found += a[i] + " ";
                        if (count >= n) break;
                    }
                }
                if (count == 0) Console.WriteLine("[]");
                else
                {
                    int[] tempArray = found.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    Array.Reverse(tempArray);
                    Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
                }
            }
        }
    }
}

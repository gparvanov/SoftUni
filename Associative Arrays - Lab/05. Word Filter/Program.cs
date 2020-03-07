﻿using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split()
                .Where( x => x.Length % 2 == 0 )
                .ToList();
            Console.WriteLine(string.Join("\n",words));
        }
    }
}
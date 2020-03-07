using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(student))
                {
                    students[student] = new List<double>();
                }
                students[student].Add(grade);
            }
            var result = students
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x => x.Value.Average());
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
            }
        }
    }
}
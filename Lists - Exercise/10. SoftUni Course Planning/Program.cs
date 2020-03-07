using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            string command = "";
            command = Console.ReadLine();
            while(command != "course start")
            {
                if (command == "course start") break;
                string[] input = command.Split(":").ToArray();
                if (input[0] == "Add" && !lessons.Contains(input[1])) lessons.Add(input[1]);
                else if (input[0] == "Insert" && !lessons.Contains(input[1])) lessons.Insert(int.Parse(input[2]), input[1]);
                else if (input[0] == "Remove" && lessons.Contains(input[1]))
                {
                    lessons.Remove(input[1]);
                    if (lessons.Contains(input[1] + "-Exercise")) lessons.Remove(input[1] + "-Exercise");
                }
                else if (input[0] == "Swap" && lessons.Contains(input[1]) && lessons.Contains(input[2]))
                {
                    string lesson1 = input[1];
                    int lesson1Index = 0;
                    bool hasExercise1 = false;
                    bool hasExercise2 = false;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == input[1]) lesson1Index = i;
                        if (lessons.Contains(input[1] + "-Exercise")) hasExercise1=true;
                    }
                    string lesson2 = input[2];
                    int lesson2Index = 0;
                    for (int i = 0; i < lessons.Count; i++)
                    {
                        if (lessons[i] == input[2]) lesson2Index = i;
                        if (lessons.Contains(input[2] + "-Exercise")) hasExercise2 = true;
                    }
                    if (!hasExercise1 && !hasExercise2)
                    {
                        lessons[lesson1Index] = lesson2;
                        lessons[lesson2Index] = lesson1;                        
                    }
                    else if (hasExercise1 && hasExercise2)
                    {
                        lessons[lesson1Index] = lesson2;
                        lessons[lesson1Index+1] = lesson2 + "-Exercise";
                        lessons[lesson2Index] = lesson1;
                        lessons[lesson2Index+1] = lesson1 + "-Exercise";
                    }
                    else if (hasExercise1 && !hasExercise2)
                    {
                        lessons[lesson1Index] = lesson2;                        
                        lessons[lesson2Index] = lesson1;
                        lessons.Insert(lesson2Index + 1, input[1] + "-Exercise");
                        lessons.RemoveAt(lesson1Index+1);
                    }
                    else if (!hasExercise1 && hasExercise2)
                    {
                        lessons[lesson1Index] = lesson2;                        
                        lessons[lesson2Index] = lesson1;
                        lessons.Insert(lesson1Index + 1, input[2] + "-Exercise");
                        lessons.RemoveAt(lesson2Index+2);
                    }
                }
                else if (input[0] == "Exercise")
                {
                    if (lessons.Contains(input[1]))
                    {                        
                        for (int i = 0; i < lessons.Count; i++)
                        {
                            if (lessons[i] == input[1])
                            {
                                int lessonIndex = i;
                                if (!lessons.Contains(input[1] + "-Exercise"))
                                {
                                    lessons.Insert(lessonIndex + 1, input[1] + "-Exercise");
                                }
                            }
                        }
                    }
                    else
                    {
                        lessons.Add(input[1]);
                        lessons.Add(input[1]+"-Exercise");
                    }
                }
                command = Console.ReadLine();                
            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }
        }
    }
}
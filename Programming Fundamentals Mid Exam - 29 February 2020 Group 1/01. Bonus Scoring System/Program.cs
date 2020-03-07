using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int attendences = 0;
            
            for (int i = 1; i <= students; i++)
            {
                int currentStudentAttendance = int.Parse(Console.ReadLine());

                int totalBonus = (int)Math.Ceiling(currentStudentAttendance * 1.0 / lectures * (5 + bonus));
                if (totalBonus >= maxBonus)
                {
                    maxBonus = totalBonus;
                    attendences = currentStudentAttendance;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {attendences} lectures.");
        }
    }
}

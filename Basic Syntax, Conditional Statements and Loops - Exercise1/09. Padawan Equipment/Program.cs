using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightSabersPrice = float.Parse(Console.ReadLine());
            float robePrice = float.Parse(Console.ReadLine());
            float bellPrice = float.Parse(Console.ReadLine());

            int extralightSabers = (int)Math.Ceiling(students * 0.1);

            int totalLightSabers = students + extralightSabers;
            float totalLightSabersPrice = totalLightSabers * lightSabersPrice;

            int totalBells = students - (students / 6 );
            float totalBellsPrice = totalBells * bellPrice;
            int totalRobes = students;
            float totalRobesPrice = totalRobes * robePrice;

            float totalEquipmentsCosts = totalLightSabersPrice + totalBellsPrice + totalRobesPrice;

            if(budget >= totalEquipmentsCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {totalEquipmentsCosts:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalEquipmentsCosts - budget):F2}lv more.");
            }

        }
    }
}

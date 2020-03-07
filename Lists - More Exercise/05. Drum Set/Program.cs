using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumsSetList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> workingDrumsSet = drumsSetList.ToList();
            string command = "";
            command = Console.ReadLine();            
            while ( command !="Hit it again, Gabsy!")
            {
                int power = int.Parse(command);
                for (int i = 0; i < workingDrumsSet.Count; i++)
                {
                    if (workingDrumsSet[i] > power) workingDrumsSet[i] -= power;
                    else
                    {
                        workingDrumsSet[i] = drumsSetList[i];
                        int purchaseMoney = drumsSetList[i] * 3;
                        if (savings > purchaseMoney) savings -= purchaseMoney;
                        else
                        {
                            workingDrumsSet.RemoveAt(i);
                            drumsSetList.RemoveAt(i);
                            i--;
                        }                        
                    }                    
                }                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",workingDrumsSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
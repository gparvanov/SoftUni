using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            long min = 0;
            long max = sizeOfTheField - 1;
            int[] bugsStartPosition = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] fieldWithBug = new int[Math.Abs(sizeOfTheField)];
            if (bugsStartPosition.Length > fieldWithBug.Length) return;
            for (int i = 0; i < bugsStartPosition.Length; i++)
            {
                long bug = bugsStartPosition[i];
                if(bug>=min && bug <=max) fieldWithBug[bug] = 1;
            }
            string command = "";
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end") break;

                string[] action = command.Split().ToArray();
                int ladybug = int.Parse(action[0]);
                string direction = action[1];
                int moves = int.Parse(action[2]);
                
                if (ladybug >= min && ladybug <= max )
                {
                    bool successfull = false;
                    int newPosition = 0;
                    if (direction == "right") newPosition = ladybug + moves;
                    else if (direction == "left") newPosition = ladybug - moves;
                    while (!successfull && fieldWithBug[ladybug] !=0)
                    {
                        if (newPosition > max || newPosition < min)
                        {
                            fieldWithBug[ladybug] = 0;
                            successfull = true;                            
                        }                        
                        else if (fieldWithBug[newPosition] == 0)
                        {
                            fieldWithBug[ladybug] = 0;
                            fieldWithBug[newPosition] = 1;
                            successfull = true;                            
                        }
                        else if (fieldWithBug[newPosition] == 1)
                        {
                            if (direction == "right") newPosition+=moves;
                            else newPosition-=moves;
                            if (newPosition > max || newPosition < min)
                            {
                                fieldWithBug[ladybug] = 0;
                                break;
                            }                            
                        }
                    }
                }
            }
            Console.WriteLine("{0}", String.Join(" ", fieldWithBug));
        }
    }
}

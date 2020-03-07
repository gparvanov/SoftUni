using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int leftCardsPlayer1 = player1.Count;
            int leftCardsPlayer2 = player2.Count;
            bool endOfGame = false;

            while ( leftCardsPlayer1!=0 && leftCardsPlayer2 != 0)
            {
                int minComparisons = Math.Min(player1.Count, player2.Count);
                for (int i = 0; i < minComparisons; i++)
                {
                    if (player1[i] > player2[i])
                    {
                        int removedCard1 = player2[i];
                        int removedCard2 = player1[i];
                        player1.Add(removedCard1);
                        player1.Add(removedCard2);
                        player1.RemoveAt(i);
                        player2.RemoveAt(i);
                        leftCardsPlayer1++;
                        leftCardsPlayer2--;
                        i--;
                    }
                    else if (player2[i] > player1[i])
                    {
                        int removedCard1 = player1[i];
                        int removedCard2 = player2[i];
                        player2.Add(removedCard1);
                        player2.Add(removedCard2);
                        player1.RemoveAt(i);
                        player2.RemoveAt(i);
                        leftCardsPlayer2++;
                        leftCardsPlayer1--;
                        i--;
                    }
                    else if (player1[i] == player2[i])
                    {
                        player1.RemoveAt(i);
                        leftCardsPlayer1--;
                        player2.RemoveAt(i);
                        leftCardsPlayer2--;
                        i--;
                    }
                    if (leftCardsPlayer1 == 0 || leftCardsPlayer2 == 0)
                    {
                        endOfGame = true;
                        break;
                    }                    
                }
                if (endOfGame) break;
            }
            if(leftCardsPlayer1>0 && leftCardsPlayer2 ==0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(player1)}");
            }
            else if (leftCardsPlayer1 == 0 && leftCardsPlayer2 > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(player2)}");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
        static int Sum(List<int> l)
        {
            int sum = 0;

            for (int i = 0; i < l.Count; i++)
            {
                sum += l[i];
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while(command!= "Season end")
            {
                if(command.Contains(" -> "))
                {
                    string[] data = command.Split(" -> ");
                    string player = data[0];
                    string position = data[1];
                    int skill = int.Parse(data[2]);
                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>();
                        players[player].Add(position, skill);
                    }
                    else if (players.ContainsKey(player) && !players[player].ContainsKey(position))
                    {
                        players[player].Add(position, skill);
                    }
                    else if (players.ContainsKey(player) && players[player].ContainsKey(position))
                    {
                        if (players[player][position] < skill) players[player][position] = skill;
                    }
                }
                else if (command.Contains(" vs "))
                {
                    string[] data = command.Split(" vs ");
                    string player1 = data[0];
                    string player2 = data[1];
                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        Dictionary<string, int> player1Positions = players[player1];
                        foreach (var item in player1Positions)
                        {
                            string player1Position = item.Key;
                            int player1PositionPoints = item.Value;
                            if (players[player2].ContainsKey(player1Position))
                            {
                                int player2PositionPoints = players[player2][player1Position];
                                if(player1PositionPoints > player2PositionPoints)
                                {
                                    players.Remove(player2);
                                }
                                else if (player1PositionPoints < player2PositionPoints)
                                {
                                    players.Remove(player1);
                                }
                                break;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            var result = players.OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key);
            foreach (var item in result)
            {
                Dictionary<string, int> innerDict = item.Value;
                Console.WriteLine($"{item.Key}: {innerDict.Values.Sum()} skill");
                var personal = innerDict.OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);
                foreach (var inner in personal)
                {
                    Console.WriteLine($"- {inner.Key} <::> {inner.Value}");
                }
            }
        }
    }
}
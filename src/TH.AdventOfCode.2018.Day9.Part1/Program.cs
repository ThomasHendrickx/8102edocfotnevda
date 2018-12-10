using System;
using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day9.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfPlayers = 411;
            const int lastMarbleValue = 72059;

            var players = new List<Player>();
            for (var i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player(Guid.NewGuid()));
            }
            
            var game = new Game(players, lastMarbleValue);
            game.Play();
            Console.WriteLine($"Player won with a score of: {game.Winner.Score}");
        }
    }
}
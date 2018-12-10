using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TH.AdventOfCode._2018.Day9.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfPlayers = 411;
            const int lastMarbleValue = 7205900;

            var stopwatch = Stopwatch.StartNew();
            var players = new List<Player>();
            for (var i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player(Guid.NewGuid()));
            }
            
            var game = new Game(players, lastMarbleValue);
            game.Play();
            stopwatch.Stop();
            Console.WriteLine($"Player won with a score of: {game.Winner.Score}");
            Console.WriteLine($"Calculated in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
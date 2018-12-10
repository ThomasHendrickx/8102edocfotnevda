using System;

namespace TH.AdventOfCode._2018.Day9
{
    public class Player
    {
        public Player(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
        public long Score { get; private set; }

        public void AddScore(long scoreToAdd)
        {
            Score += scoreToAdd;
        }
    }
}
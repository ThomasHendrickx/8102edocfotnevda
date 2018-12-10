using System;

namespace TH.AdventOfCode._2018.Day6.Part1
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int ManhattenDistance(Coordinate coordinate)
        {
            return Math.Abs(X - coordinate.X) + Math.Abs(Y - coordinate.Y);
        }
    }
}
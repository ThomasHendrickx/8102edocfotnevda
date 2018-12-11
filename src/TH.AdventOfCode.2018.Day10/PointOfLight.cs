using System;
using System.Text.RegularExpressions;

namespace TH.AdventOfCode._2018.Day10
{
    public class PointOfLight
    {
        private static readonly Regex PoLRegex = new Regex(@"^position=<\s?(?<xPos>-?\d+), \s?(?<yPos>-?\d+)> velocity=<\s?(?<xSpeed>-?\d+), \s?(?<ySpeed>-?\d+)>$");
        public static PointOfLight FromString(string description)
        {
            var match = PoLRegex.Match(description);
            var coordinate = new Coordinate(int.Parse(match.Groups["xPos"].Value), int.Parse(match.Groups["yPos"].Value));
            var speed = new Vector(int.Parse(match.Groups["xSpeed"].Value), int.Parse(match.Groups["ySpeed"].Value));
            return new PointOfLight(coordinate, speed);
        }
        
        public Coordinate Coordinate { get; private set; }
        private readonly Vector _speed;

        public PointOfLight(Coordinate start, Vector speed)
        {
            Coordinate = start;
            _speed = speed;
        }

        public void Move(int amount)
        {
            Coordinate = Coordinate.MoveWithSpeed(_speed * amount);
        }

        public int ManhattenDistanceFrom(PointOfLight pointOfLight)
        {
            return Math.Abs(Coordinate.X - pointOfLight.Coordinate.X) + Math.Abs(Coordinate.Y - pointOfLight.Coordinate.Y);
        }
    }
}
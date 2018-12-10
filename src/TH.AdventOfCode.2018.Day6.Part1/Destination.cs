using System;

namespace TH.AdventOfCode._2018.Day6.Part1
{
    public class Destination
    {
        private static int NextId = 0;
        
        public Guid Id { get; }
        public string VisibleId { get; }
        public Coordinate Coordinate { get; }

        public Destination(string coordinate)
        {
            Id = Guid.NewGuid();
            VisibleId = NextId > 9 ? NextId++.ToString() : $"0{NextId++}";

            var coordinateSplit = coordinate.Split(',');
            Coordinate = new Coordinate
            {
                X = int.Parse(coordinateSplit[0].Trim()),
                Y = int.Parse(coordinateSplit[1].Trim())
            };
        }
    }
}
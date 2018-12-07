using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TH.AdventOfCode._2018.Day3.Part1
{
    public class Claim
    {
        public static readonly Regex ClaimRegex =
            new Regex(@"#(?<id>[0-9]+) @ (?<x>[0-9]+),(?<y>[0-9]+): (?<w>[0-9]+)x(?<h>[0-9]+)");
        
        
        public string Id { get; }
        public IEnumerable<Coordinate> Claims { get; }

        public Claim(string claim)
        {
            Console.WriteLine($"Processing claim {claim}");
            var result = ClaimRegex.Match(claim);
            Id = result.Groups["id"].Value;
            var x = int.Parse(result.Groups["x"].Value);
            var y = int.Parse(result.Groups["y"].Value);
            var w = int.Parse(result.Groups["w"].Value);
            var h = int.Parse(result.Groups["h"].Value);

            var xCoordinates = new List<int>();
            var yCoordinates = new List<int>();
            for (var i = 1; i <= w; i++)
            {
                xCoordinates.Add(x + i);
            }
            for (var j = 1; j <= h; j++)
            {
                yCoordinates.Add(y + j);
            }

            var claims = new List<Coordinate>();
            foreach (var xCoordinate in xCoordinates)
            {
                foreach (var yCoordinate in yCoordinates)
                {
                    claims.Add(new Coordinate {X = xCoordinate, Y = yCoordinate});
                }
            }

            Claims = claims;
        }

        public IEnumerable<string> AsPrint()
        {
            return Claims.OrderBy(c => c.Y).GroupBy(c => c.Y).Select(rows => rows.OrderBy(c => c.X).Aggregate("  ", (current, cell) => current + $"[{cell.X},{cell.Y}]  ")).ToList();
        }
    }
}
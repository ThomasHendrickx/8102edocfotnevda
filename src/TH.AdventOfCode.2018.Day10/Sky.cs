using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace TH.AdventOfCode._2018.Day10
{
    public class Sky
    {
        private readonly IEnumerable<PointOfLight> _pointsOfLight;
        public int Second { get; private set; }

        public Sky(IEnumerable<PointOfLight> pointsOfLight)
        {
            _pointsOfLight = pointsOfLight;
        }

        public void Tick(int amount = 1)
        {
            Second += amount;
            foreach (var pointOfLight in _pointsOfLight)
            {
                pointOfLight.Move(amount);
            }
        }

        public int PointsNextToAnother => _pointsOfLight
            .Sum(pointOfLight => 
                _pointsOfLight.Any(p => pointOfLight.ManhattenDistanceFrom(p) == 1) ? 
                    1 : 
                    0);

        public long Surface
        {
            get
            {
                GetBoundries(out var minX, out var maxX, out var minY, out var maxY);
                return Math.Abs(maxX - minX) * Math.Abs(maxY - minY);
            }
        }

        public long Height
        {
            get
            {
                GetBoundries(out var minX, out var maxX, out var minY, out var maxY);
                return (maxY - minY);
            }
        }

        private void GetBoundries(out int minX, out int maxX, out int minY, out int maxY)
        {
            minX = int.MaxValue;
            maxX = int.MinValue;
            minY = int.MaxValue;
            maxY = int.MinValue;
            foreach (var pointOfLight in _pointsOfLight)
            {
                if (pointOfLight.Coordinate.X < minX)
                {
                    minX = pointOfLight.Coordinate.X;
                }

                if (pointOfLight.Coordinate.X > maxX)
                {
                    maxX = pointOfLight.Coordinate.X;
                }

                if (pointOfLight.Coordinate.Y < minY)
                {
                    minY = pointOfLight.Coordinate.Y;
                }

                if (pointOfLight.Coordinate.Y > maxY)
                {
                    maxY = pointOfLight.Coordinate.Y;
                }
            }
        }

        public void Print(Action<string> linePrinter)
        {
            int minX = int.MaxValue, maxX = int.MinValue, minY = int.MaxValue, maxY = int.MinValue;
            foreach (var pointOfLight in _pointsOfLight)
            {
                if (pointOfLight.Coordinate.X < minX)
                {
                    minX = pointOfLight.Coordinate.X;
                }
                if (pointOfLight.Coordinate.X > maxX)
                {
                    maxX = pointOfLight.Coordinate.X;
                }
                if (pointOfLight.Coordinate.Y < minY)
                {
                    minY = pointOfLight.Coordinate.Y;
                }                
                if (pointOfLight.Coordinate.Y > maxY)
                {
                    maxY = pointOfLight.Coordinate.Y;
                }
            }

            for (var y = (minY - 1); y <= (maxY + 1); y++)
            {
                var line = "";
                var pointsOnLine = _pointsOfLight.Where(p => p.Coordinate.Y == y).ToList();
                for (var x = (minX - 1); x <= (maxX + 1); x++)
                {
                    line += pointsOnLine.Any(p => p.Coordinate.X == x) ? "#" : ".";
                }
                linePrinter.Invoke(line);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace TH.AdventOfCode._2018.Day6.Part1
{
    public class Map
    {
        public List<Destination> Destinations { get; }
        public List<Point> Points { get; }

        private int? MinX { get; set; }
        private int? MinY { get; set; }
        private int? MaxX { get; set; }
        private int? MaxY { get; set; }
        
        public Map(List<Destination> destinations)
        {
            Destinations = destinations;
            Points = new List<Point>();
            SetMinMax();
            AssignAllPoints();
        }

        private void SetMinMax()
        {            
            foreach (var destination in Destinations)
            {
                if (MinX == null || MinX > destination.Coordinate.X)
                {
                    MinX = destination.Coordinate.X;
                }
                if (MinY == null || MinY > destination.Coordinate.Y)
                {
                    MinY = destination.Coordinate.Y;
                }
                if (MaxX == null || MaxX < destination.Coordinate.X)
                {
                    MaxX = destination.Coordinate.X;
                }
                if (MaxY == null || MaxY < destination.Coordinate.Y)
                {
                    MaxY = destination.Coordinate.Y;
                }
            }
        }

        private void AssignAllPoints()
        {
            Points.Clear();
            for (var x = MinX.Value; x <= MaxX.Value; x++)
            {
                for (var y = MinY.Value; y <= MaxY.Value; y++)
                {
                    var coordinate = new Coordinate
                    {
                        X = x,
                        Y = y
                    };
                    var orderedDestinations = Destinations.Select(d => new
                    {
                        Distance = d.Coordinate.ManhattenDistance(coordinate),
                        Destination = d
                    }).OrderBy(d => d.Distance).ToList();
                    if (orderedDestinations[0].Distance == orderedDestinations[1].Distance)
                    {
                        Points.Add(new Point
                        {
                            Coordinate = coordinate,
                            Owner = null
                        });                  
                    }
                    else
                    {
                        Points.Add(new Point
                        {
                            Coordinate = coordinate,
                            Owner = orderedDestinations.First().Destination
                        });
                    }
                }
            }
        }

        private List<Destination> FilteredDestinations
        {
            get
            {
                var destinationsToIgnore = new List<Destination>();
                foreach (var point in Points.Where(p =>
                    p.Coordinate.X == MinX ||
                    p.Coordinate.X == MaxX ||
                    p.Coordinate.Y == MinY ||
                    p.Coordinate.Y == MaxY))
                {
                    if (point.Owner != null && !destinationsToIgnore.Contains(point.Owner))
                    {
                        destinationsToIgnore.Add(point.Owner);
                    }
                }

                return Destinations.Except(destinationsToIgnore).ToList();
            }
        }

        public Destination DestinationWithMostPoints
        {
            get
            {
                var destinations = new List<Tuple<int, Destination>>();
                foreach (var destination in FilteredDestinations)
                {
                    destinations.Add(new Tuple<int, Destination>(SizeOf(destination), destination));
                }

                return destinations.OrderByDescending(t => t.Item1).First().Item2;
            }
        }

        public int SizeOf(Destination destination)
        {
            var count = 0;
            foreach (var point in Points)
            {
                if (point.Owner != null && point.Owner.Id == destination.Id)
                {
                    count++;
                }
            }

            return count;
        }

        public void PrintOutTo(Action<string> linePrinter)
        {
            for (var y = MinY; y <= MaxY; y++)
            {
                var lineToPrint = "";
                for (var x = MinX; x <= MaxX; x++)
                {
                    var point = Points.First(p => p.Coordinate.X == x && p.Coordinate.Y == y);
                    lineToPrint += $" {(point.Owner?.VisibleId ?? "..")}";
                }
                linePrinter.Invoke(lineToPrint);
            }
        }
    }
}
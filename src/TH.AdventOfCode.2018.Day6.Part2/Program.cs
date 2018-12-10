using System;
using System.Linq;
using TH.AdventOfCode._2018.Day6.Part1;

namespace TH.AdventOfCode._2018.Day6.Part2
{
    class Program
    {
        static void Main()
        {            
            var destinations = Input.Value.Split(';').Select(coor => new Destination(coor));
            var map = new Map(destinations.ToList()); 
            Console.WriteLine($"Answer = {map.PointsWithTotalDistanceLowerThan(10000).Count}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TH.AdventOfCode._2018.Day6.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var destinations = Input.Value.Split(';').Select(coor => new Destination(coor));
            var map = new Map(destinations.ToList());
            var d = map.DestinationWithMostPoints;            
            Console.WriteLine($"Answer ({d.VisibleId}) = {map.SizeOf(d)}");
        }
    }
}
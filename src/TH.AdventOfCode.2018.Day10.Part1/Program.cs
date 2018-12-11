using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TH.AdventOfCode._2018.Day10.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startingTicks = 0;
            var points = Input.Value.Split(';').Select(PointOfLight.FromString).ToList();
            var sky = new Sky(points);
            var surfaces = new List<long>();
            sky.Tick(startingTicks);
            var count = 0;
            while (count++ < 11000)
            {
                sky.Tick();
                surfaces.Add(Math.Abs(sky.Surface));
                Console.WriteLine(Math.Abs(sky.Surface));
            }

            var maxTick = surfaces.IndexOf(surfaces.Min()) + startingTicks;
            sky = new Sky(Input.Value.Split(';').Select(PointOfLight.FromString).ToList());
            sky.Tick(maxTick - 10);
            Console.WriteLine($"Max tick: {maxTick} with height {sky.Surface}");
            for (int i = 0; i < 20; i++)
            {
                var lines = new List<string>();
                Console.WriteLine(sky.Second);
                sky.Print(line =>
                {
                    lines.Add(line);
                    Console.WriteLine(line);
                });
                sky.Tick();
                Console.ReadLine();
            }
        }

        private static bool TheyAreFadingAwaaaaaaaaayyyyyy(IEnumerable<long> surfaces)
        {
            var previousSurface = long.MaxValue;
            foreach (var surface in surfaces)
            {
                if (surface > previousSurface) return true;
                previousSurface = surface;
            }

            return false;
        }
    }
}
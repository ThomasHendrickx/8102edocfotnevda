using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day11.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerLevels = new Dictionary<string, int>();
            for (var i = 1; i <= 300; i++)
            {
                var grid = new Grid(9110, i);
                var max = grid.HightestPowerSelection;
                powerLevels.Add($"({max.X},{max.Y},{i})", max.Power);
                Console.WriteLine($"Grid {i} has {max.Power} power");
                if (max.Power <= 0)
                {
                    break;
                }
            }

            var highets = powerLevels.Values.Max();
            var gridIdentifier = powerLevels.First(kv => kv.Value == highets).Key;
            Console.WriteLine($"Answer to 11.2 = {gridIdentifier}");
        }
    }
}
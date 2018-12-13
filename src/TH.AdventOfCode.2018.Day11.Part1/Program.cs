using System;

namespace TH.AdventOfCode._2018.Day11.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new Grid(9110, 3);
            var p = grid.HightestPowerSelection;
            Console.WriteLine($"For grid found ({p.X},{p.Y})");
        }
    }
}
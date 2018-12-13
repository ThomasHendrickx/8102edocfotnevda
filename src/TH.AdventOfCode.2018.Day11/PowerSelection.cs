using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day11
{
    public class PowerSelection
    {
        public int X { get; }
        public int Y { get; }
        private List<Point> _points;
        
        public PowerSelection(int x, int y, int serial, int squareSide = 3)
        {
            X = x;
            Y = y;
            _points = new List<Point>();
            for (var _x = x; _x < x + squareSide; _x++)
            {
                for (var _y = y; _y < y + squareSide; _y++)
                {
                    _points.Add(new Point(_x, _y, serial));
                }                
            }
        }

        public int Power => _points.Select(p => p.PowerLevel).Sum();
    }
}
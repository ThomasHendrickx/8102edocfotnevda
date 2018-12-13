using System;

namespace TH.AdventOfCode._2018.Day11
{
    public class Point
    {
        private readonly int _serial;
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y, int serial)
        {
            _serial = serial;
            X = x;
            Y = y;
        }

        public int PowerLevel
        {
            get
            {
                var rackId = X + 10;
                var powerlevel = rackId * Y;
                powerlevel += _serial;
                powerlevel *= rackId;
                var digit = powerlevel < 100 ? 0 : (int) Math.Abs(powerlevel / 100 % 10);
                return digit - 5;
            }
        }
    }
}
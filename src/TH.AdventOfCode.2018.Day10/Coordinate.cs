namespace TH.AdventOfCode._2018.Day10
{
    public struct Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate MoveWithSpeed(Vector speed)
        {
            return new Coordinate(X + speed.X, Y + speed.Y);
        }
    }
}
namespace TH.AdventOfCode._2018.Day10
{
    public struct Vector
    {
        public int X { get; }
        public int Y { get; }
        
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator *(Vector v1, int amount)
        {
            return new Vector(v1.X * amount, v1.Y * amount);
        }
    }
}
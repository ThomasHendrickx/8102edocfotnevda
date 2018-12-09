using System;

namespace TH.AdventOfCode._2018.Day5.Part1
{
    public struct Unit
    {
        public char Type { get; }
        public Polarity Polarity { get; }

        public Unit(char element)
        {
            Type = char.ToLower(element); 
            Polarity = char.IsUpper(element) ? 
                Polarity.Positive : 
                Polarity.Negative;
        }

        public bool CanReactWith(Unit unit) => unit.Polarity != Polarity && unit.Type == Type;

        public char AsChar()
        {
            switch (Polarity)
            {
                case Polarity.Positive:
                    return char.ToUpperInvariant(Type);
                case Polarity.Negative:
                    return char.ToLowerInvariant(Type);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return AsChar().ToString();
        }
    }
}
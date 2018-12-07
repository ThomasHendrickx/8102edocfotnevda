using System;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    public struct TimeSpan
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        public TimeSpan(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public int NumberOfMinutes => End.Subtract(Start).Minutes;
    }
}
using System;
using TH.AdventOfCode._2018.Day4.Part1;

namespace TH.AdventOfCode._2018.Day4.Part2
{
    class Program
    {
        static void Main()
        {
            var timeEntries = Input
                .TimeEntriesString
                .Split(Environment.NewLine);
            var guardProfiler = new GuardsProfiler(timeEntries);
            Console.WriteLine($"Guard {guardProfiler.GuardMostAsSleepOnSameMinuite.Id} is {guardProfiler.GuardMostAsSleepOnSameMinuite.NumberOfTimesAsleepOnTheSameMinute} minutes asleep at {guardProfiler.GuardMostAsSleepOnSameMinuite.MinuteMostAsleep}!");
        }
    }
}
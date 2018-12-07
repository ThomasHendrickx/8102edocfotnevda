using System;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    class Program
    {
        static void Main()
        {
            var timeEntries = Input
                .TimeEntriesString
                .Split(Environment.NewLine);
            var guardProfiler = new GuardsProfiler(timeEntries);
            Console.WriteLine($"Guard {guardProfiler.MostSleepyGuard.Id} is {guardProfiler.MostSleepyGuard.NumberOfMinutesAsleep} minutes asleep and mostly at {guardProfiler.MostSleepyGuard.MinuteMostAsleep}!");
        }
        
        
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    public class GuardsProfiler
    {
        private readonly IEnumerable _timeEntries;

        public GuardsProfiler(IEnumerable<string> timeEntriesAsString)
        {
            var timeEntries = timeEntriesAsString
                .Select(entryString => new TimeEntry(entryString))
                .OrderBy(entry => entry.TimeStamp.AsDateTime());
            Guards = new Dictionary<int, Guard>();
            Guard currentGuard = null;
            foreach (var timeEntry in timeEntries)
            {
                switch (timeEntry.TimeEntryType)
                {
                    case TimeEntryTypes.BeginShift:
                        if (!Guards.TryGetValue(timeEntry.Guard.Value, out currentGuard))
                        {
                            currentGuard = new Guard(timeEntry.Guard.Value);
                            Guards.Add(currentGuard.Id, currentGuard);
                        }
                        break;
                    case TimeEntryTypes.StartAsleep:
                        currentGuard?.SetAsleep(timeEntry.TimeStamp.AsDateTime());
                        break;
                    case TimeEntryTypes.EndAsleep:
                        currentGuard?.Awake(timeEntry.TimeStamp.AsDateTime());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }                         
            }
        }

        public Dictionary<int, Guard> Guards { get; }

        public Guard MostSleepyGuard => Guards.Values.OrderByDescending(guard => guard.NumberOfMinutesAsleep).First();

        public Guard GuardMostAsSleepOnSameMinuite =>
            Guards.Values.Where(guard => guard.NumberOfMinutesAsleep > 0).OrderByDescending(guard => guard.NumberOfTimesAsleepOnTheSameMinute).First();
    }
}
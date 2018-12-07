using System.Text.RegularExpressions;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    public class TimeEntry
    {
        private static Regex TimeEntryRegex = new Regex(@"^\[(?<timestamp>[^]]+)\] (?<entrytype>.+)$");
        private static Regex GuardRegex = new Regex(@"^Guard #(?<guardNumber>\d+) begins shift$");
        
        public TimeStamp TimeStamp { get; }
        public TimeEntryTypes TimeEntryType { get; }
        public int? Guard { get; }

        public TimeEntry(string timeEntry)
        {
            var match = TimeEntryRegex.Match(timeEntry);
            TimeStamp = new TimeStamp(match.Groups["timestamp"].Value);
            var timeEntryPart = match.Groups["entrytype"].Value;
            TimeEntryType = AsTimeEntryTypes(timeEntryPart);
            if (GuardRegex.IsMatch(timeEntryPart))
            {
                var guardMatch = GuardRegex.Match(timeEntryPart);
                Guard = int.Parse(guardMatch.Groups["guardNumber"].Value);
            }
        }

        private TimeEntryTypes AsTimeEntryTypes(string timeEntryType)
        {
            timeEntryType = timeEntryType.Trim();
            if (timeEntryType.StartsWith("Guard"))
            {
                return TimeEntryTypes.BeginShift;
            }
            if (timeEntryType.StartsWith("falls"))
            {
                return TimeEntryTypes.StartAsleep;
            }
            if (timeEntryType.StartsWith("wake"))
            {
                return TimeEntryTypes.EndAsleep;
            }

            return TimeEntryTypes.Unknown;
        }
    }
}
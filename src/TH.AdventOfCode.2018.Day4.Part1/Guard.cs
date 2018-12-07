using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    public class Guard
    {
        public int Id { get; }
        private readonly List<TimeSpan> _momentsAsleep;
        private DateTime? _asleepFrom;

        public Guard(int id)
        {
            Id = id;
            _momentsAsleep = new List<TimeSpan>();
        }
        
        public void SetAsleep(DateTime timestamp)
        {
            _asleepFrom = timestamp;
        }

        public void Awake(DateTime timestamp)
        {
            if (_asleepFrom == null)
            {
                throw new CanAwakeWhenAwakeException();
            }

            _momentsAsleep.Add(new TimeSpan(_asleepFrom.Value, timestamp));
            _asleepFrom = null;
        }

        public int NumberOfMinutesAsleep => _momentsAsleep.Aggregate(0, (asleepAlready, span) => asleepAlready + span.NumberOfMinutes);

        public int MinuteMostAsleep
        {
            get
            {
                var minutes = NumberOfTimesAsleepForEachMinute();
                return minutes.OrderByDescending(kv => kv.Value).First().Key;
            }
        }

        public int NumberOfTimesAsleepOnTheSameMinute
        {
            get
            {
                var minutes = NumberOfTimesAsleepForEachMinute();
                return minutes.OrderByDescending(kv => kv.Value).First().Value;                
            }
        }

        private Dictionary<int, int> NumberOfTimesAsleepForEachMinute()
        {
            
            var minutes = new Dictionary<int, int>();
            foreach (var momentAsleep in _momentsAsleep)
            {
                var startMinute = momentAsleep.Start.Minute;
                var endMinute = momentAsleep.End.Minute;
                for (var minute = startMinute; minute < endMinute; minute++)
                {
                    if (!minutes.ContainsKey(minute))
                    {
                        minutes.Add(minute, 0);
                    }

                    minutes[minute]++;
                }
            }

            return minutes;
        }
    }
}
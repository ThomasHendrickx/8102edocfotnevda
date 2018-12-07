using System;

namespace TH.AdventOfCode._2018.Day4.Part1
{
    public class TimeStamp
    {
        private readonly string _timeStamp;

        public TimeStamp(string timeStamp)
        {
            _timeStamp = timeStamp;
        }

        public DateTime AsDateTime()
        {
            return DateTime.ParseExact(_timeStamp, "yyyy-MM-dd HH:mm", null);
        }
    }
}
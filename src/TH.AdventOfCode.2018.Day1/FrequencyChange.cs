using System;

namespace TH.AdventOfCode._2018.Day1
{
    public sealed class FrequencyChange
    {
        public static FrequencyChange FromStringInput(string frequencyChange)
        {
            return new FrequencyChange(frequencyChange);
        }

        private readonly int _change;
        public int Change => _change;
        
        private FrequencyChange(string change)
        {
            change = change != null && change.StartsWith('+') ? change.Substring(1) : change;
            if (!int.TryParse(change, out _change))
            {
                throw new ArgumentException("needs to be of a valid integer format.", nameof(change));
            }
        }
    }
}
using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day1
{
    public class Frequency
    {
        public static Frequency StartFromZero()
        {
            return StartFromInteger(0);
        }

        public static Frequency StartFromInteger(int startFrequency)
        {
            return new Frequency(startFrequency);
        }

        public static Frequency StartFromFrequency(Frequency frequency)
        {
            return StartFromInteger(frequency.FrequencyNumber);
        }
                
        private readonly int _startFrequency;
        private readonly List<FrequencyChange> _frequencyChanges;

        private Frequency(int startFrequency)
        {
            _startFrequency = startFrequency;
            _frequencyChanges = new List<FrequencyChange>();
        }

        public void Add(FrequencyChange change)
        {
            _frequencyChanges.Add(change);
        }

        public void Add(FrequencyChangeSequence sequence)
        {
            foreach (var change in sequence.Changes)
            {
                Add(change);
            }
        }

        public int FrequencyNumber
        {
            get
            {
                var frequency = _startFrequency;
                foreach (var frequencyChange in _frequencyChanges)
                {
                    frequency += frequencyChange.Change;
                }

                return frequency;
            }
        }
    }
}
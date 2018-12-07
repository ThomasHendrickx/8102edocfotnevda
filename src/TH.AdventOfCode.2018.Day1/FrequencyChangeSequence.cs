using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day1
{
    public sealed class FrequencyChangeSequence
    {
        public static FrequencyChangeSequence FromCommaSeperatedValues(CommaSeperatedValues changeSequence)
        {
            return new FrequencyChangeSequence(changeSequence);
        }


        private readonly List<FrequencyChange> _changes;
        public IReadOnlyList<FrequencyChange> Changes => _changes.AsReadOnly(); 
        
        private FrequencyChangeSequence(CommaSeperatedValues changeSequence)
        {
            if (changeSequence == null)
            {
                throw new ArgumentNullException(nameof(changeSequence));
            }

            _changes = changeSequence.Values.Select(FrequencyChange.FromStringInput).ToList();
        }
    }
}
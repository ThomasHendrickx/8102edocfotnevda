using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day1
{
    public class CommaSeperatedValues
    {
        public static CommaSeperatedValues FromString(string values)
        {
            return new CommaSeperatedValues(values);
        }

        private readonly List<string> _values;
        public IReadOnlyList<string> Values => _values;
        
        private CommaSeperatedValues(string values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            _values = values.Split(',').Select(v => v.Trim()).ToList();
        }
    }
}
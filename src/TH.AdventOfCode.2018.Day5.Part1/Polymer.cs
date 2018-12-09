using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day5.Part1
{
    public class Polymer
    {
        private List<Unit> _sequence;

        public Polymer(string sequence)
        {
            _sequence = sequence
                .Select(c => new Unit(c))
                .ToList();
        }                

        public void React()
        {
            var i = 0;
            while (CanReact)
            {
                ReduceFirst();
                Console.WriteLine(++i);
            }
        }

        private void ReduceFirst()
        {
            Unit? previousUnit = null;
            var count = 0;
            var previousCount = -10;
            foreach (var element in _sequence)
            {
                if (previousUnit?.CanReactWith(element) ?? false)
                {
                    _sequence.RemoveAt(count);
                    _sequence.RemoveAt(previousCount);
                    return;
                }                
                previousCount = count;
                previousUnit = element;
                count++;
            }
        }

        private bool CanReact
        {
            get
            {
                Unit? previousUnit = null;
                foreach (var element in _sequence)
                {
                    if (previousUnit?.CanReactWith(element) ?? false)
                    {
                        return true;
                    }
                    previousUnit = element;                    
                }

                return false;
            }
        }

        public List<List<Unit>> AllTypes
        {
            get
            {
                var types = new Dictionary<char, List<Unit>>();
                foreach (var unit in _sequence)
                {
                    var lowerChar = char.ToLower(unit.AsChar());
                    if (types.ContainsKey(lowerChar)) continue;
                    
                    var upperChar = char.ToUpper(unit.AsChar());
                    types.Add(lowerChar, new List<Unit>
                    {
                        new Unit(lowerChar),
                        new Unit(upperChar)
                    });
                }

                return types.Values.ToList();
            }
        }

        public Polymer WithoutTypes(List<Unit> types)
        {
            return new Polymer(new string(_sequence.Where(unit => !types.Contains(unit)).Select(unit => unit.AsChar()).ToArray()));
        }

        public string Sequence => new string(_sequence.Select(element => element.AsChar()).ToArray());
    }
}
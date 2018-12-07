using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day2
{
    public class BoxId
    {
        private readonly Dictionary<char, int> _letters;
        
        public List<int> Multiple 
        {
            get
            {
                var list = new List<int>();
                foreach (var value in _letters.Values.Where(v => v > 1))
                {
                    if (!list.Contains(value))
                    {
                        list.Add(value);
                    }
                }

                return list;
            }
        } 
        
        public BoxId(string idString)
        {
            if (idString == null)
            {
                throw new ArgumentNullException(nameof(idString));
            }

            _letters = new Dictionary<char, int>();
            foreach (var letter in idString)
            {
                if (!_letters.ContainsKey(letter))
                {
                    _letters.Add(letter, 0);
                }

                _letters[letter]++;
            }
        }
    }
}
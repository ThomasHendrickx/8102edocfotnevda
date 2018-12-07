using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day2.Part1
{
    public class CheckSum
    {
        private readonly IReadOnlyList<BoxId> _boxIds;

        public CheckSum(IReadOnlyList<BoxId> boxIds)
        {
            _boxIds = boxIds;
        }

        public int Result
        {
            get
            {
                var values = new Dictionary<int, int>();
                foreach (var boxId in _boxIds)
                {
                    foreach (var value in boxId.Multiple)
                    {
                        if (!values.ContainsKey(value))
                        {
                            values.Add(value, 0);
                        }

                        values[value]++;
                    }
                }

                return values.OrderByDescending(val => val.Key).Select(val => val.Value).Aggregate(1, (current, toMultiply) => current * toMultiply);
            }
        }
    }
}
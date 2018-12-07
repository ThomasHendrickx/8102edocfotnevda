using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day2.Part2
{
    public class DifferenceList
    {
        public static DifferenceList FromBoxIds(IEnumerable<BoxId> boxIds)
        {
            var dic = new Dictionary<string, Difference>();
            var boxIdsList = boxIds.ToList();
            foreach (var boxId in boxIdsList)
            {
                foreach (var id in boxIdsList.Where(b => boxId.Box != b.Box))
                {
                    var difference = new Difference(boxId, id);
                    if (!dic.ContainsKey(difference.Id))
                    {
                        dic.Add(difference.Id, difference);
                    }
                }
            }
            return new DifferenceList(dic.Values);
        } 
        
        private readonly IEnumerable<Difference> _differences;

        public DifferenceList(IEnumerable<Difference> differences)
        {
            _differences = differences;
        }

        public string SmallestId => _differences.OrderBy(d => d.Diff).First().CommonId;
    }
}
using System.Linq;

namespace TH.AdventOfCode._2018.Day2.Part2
{
    public class Difference
    {
        private readonly BoxId _boxId1;
        private readonly BoxId _boxId2;

        public Difference(BoxId boxId1, BoxId boxId2)
        {
            _boxId1 = boxId1;
            _boxId2 = boxId2;
        }

        public string Id => string.Concat(new[] {_boxId1.Box, _boxId2.Box}.OrderBy(x => x));

        public int Diff
        {
            get
            {
                GetPaddedIds(out var boxId1, out var boxId2);
                return boxId1.Where((t, i) => t != boxId2[i]).Count();
            }
        }

        private void GetPaddedIds(out string boxId1, out string boxId2)
        {
            if (_boxId1.Box.Length > _boxId2.Box.Length)
            {
                boxId1 = _boxId1.Box;
                boxId2 = _boxId2.Box;
                for (var i = 0; i < _boxId1.Box.Length - _boxId2.Box.Length; i++)
                {
                    boxId2 += " ";
                }
            }
            else
            {
                boxId1 = _boxId1.Box;
                boxId2 = _boxId2.Box;
                for (var i = 0; i < _boxId2.Box.Length - _boxId1.Box.Length; i++)
                {
                    boxId1 += " ";
                }
            }
        }

        public string CommonId
        {
            get
            {
                GetPaddedIds(out var boxId1, out var boxId2);
                return string.Concat(boxId1.Where((t, i) => t == boxId2[i]));
            }
        }
    }
}
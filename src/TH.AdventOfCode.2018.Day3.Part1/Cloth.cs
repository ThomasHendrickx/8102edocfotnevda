using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day3.Part1
{
    public class Cloth
    {
        private readonly Dictionary<int, Dictionary<int, List<string>>> _gridClaims = new Dictionary<int, Dictionary<int, List<string>>>();

        public void AddClaim(Claim claim)
        {
            foreach (var c in claim.Claims)
            {
                if (!_gridClaims.ContainsKey(c.X))
                {
                    _gridClaims.Add(c.X, new Dictionary<int, List<string>>());
                }

                var column = _gridClaims[c.X];
                if (!column.ContainsKey(c.Y))
                {
                    column.Add(c.Y, new List<string>());
                }

                var cell = column[c.Y];
                cell.Add(claim.Id);
            }
        }

        public int NumberOfCellsWithMultipleClaims()
        {
            return _gridClaims.Values.SelectMany(column => column.Values).Count(claims => claims.Count > 1);
        }
    }
}
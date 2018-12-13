using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day11
{
    public class Grid
    {
        private readonly int _serial;
        private readonly  List<PowerSelection> _powerSelections;
        
        public Grid(int serial, int gridSize)
        {
            _serial = serial;
            _powerSelections = new List<PowerSelection>();
            for (var y = 1; y <= (301 - gridSize); y++)
            {
                for (var x = 1; x <= (301 - gridSize); x++)
                {
                    _powerSelections.Add(new PowerSelection(x, y, serial, gridSize));
                }
            }
        }

        public PowerSelection HightestPowerSelection => _powerSelections.OrderByDescending(p => p.Power).First();    
    }
}
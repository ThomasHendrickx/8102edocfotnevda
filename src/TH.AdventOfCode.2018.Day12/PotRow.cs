using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TH.AdventOfCode._2018.Day12
{
    public class PotRow
    {
        private readonly LinkedList<Pot> _pots;
        private readonly List<SpreadCombination> _spreadCombinations;


        public PotRow(int startingFrom,string initialState, IEnumerable<SpreadCombination> spreadCombinations)
        {
            _spreadCombinations = spreadCombinations.ToList();
            _pots = new LinkedList<Pot>();
            var count = startingFrom;
            foreach (var state in initialState)
            {
                _pots.AddLast(new Pot {HasPlant = state == '#', Id = count++});
            }
        }
        
        public PotRow(int startingFrom, string initialState, IEnumerable<string> spreadCombinations)
            : this(startingFrom, initialState, spreadCombinations.Select(sc => new SpreadCombination(sc)))
        {
        }

        public int CurrentNumberOfPlants => _pots.Select(p => p.HasPlant).Count();
        public string CurrentState => string.Join("",_pots.Select(p => p.HasPlant ? '#' : '.'));
        public int CurrentSumOfPlantContainingPots => _pots.Where(p => p.HasPlant).Select(p => p.Id).Sum();

        public PotRow NextGeneration()
        {
            var potCopies = new LinkedList<Pot>(_pots.Select(p => p));
            if (potCopies.First.Next.Value.HasPlant)
            {
                potCopies.AddFirst(new Pot{HasPlant = false, Id = (potCopies.First.Value.Id - 1) });                
            }
            if (potCopies.First.Next.Value.HasPlant)
            {
                potCopies.AddFirst(new Pot{HasPlant = false, Id = (potCopies.First.Value.Id - 1) });
            }
            if (potCopies.Last.Previous.Value.HasPlant)
            {
                potCopies.AddLast(new Pot{HasPlant = false, Id = (potCopies.Last.Value.Id + 1) });
            }
            if (potCopies.Last.Previous.Value.HasPlant)
            {
                potCopies.AddLast(new Pot{HasPlant = false, Id = (potCopies.Last.Value.Id + 1) });
            }
            
            var state = "";
            var currentPot = potCopies.First;
            while(currentPot != null)
            {
                state += _spreadCombinations.Any(c => c.CanSpread(currentPot)) ? '#' : '.';
                currentPot = currentPot.Next;
            }
            
            return new PotRow(potCopies.First.Value.Id, state, _spreadCombinations);
        }
    }
}
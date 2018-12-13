using System;
using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day12
{
    public class SpreadCombination
    {
        private readonly string _spreadCombination;
        private readonly bool _secondLeftHasPlant;
        private readonly bool _firstLeftHasPlant;
        private readonly bool _currentHasPlant;
        private readonly bool _firstRightHasPlant;
        private readonly bool _secondRightHasPlant;

        public SpreadCombination(string spreadCombination)
        {
            if (spreadCombination.Length != 5)
            {
                throw new InvalidOperationException("Spread combinations other than length 5 are not supported!");
            }
            _spreadCombination = spreadCombination;
            _secondLeftHasPlant = spreadCombination[0] == '#';
            _firstLeftHasPlant = spreadCombination[1] == '#';
            _currentHasPlant = spreadCombination[2] == '#';
            _firstRightHasPlant = spreadCombination[3] == '#';
            _secondRightHasPlant = spreadCombination[4] == '#';
        }

        public bool CanSpread(LinkedListNode<Pot> pot)
        {
            if (pot.Value.HasPlant != _currentHasPlant) return false;
            if (pot.OneLeftHasPlant() != _firstLeftHasPlant) return false;
            if (pot.TwoLeftHasPlant() != _secondLeftHasPlant) return false;
            if (pot.OneRightHasPlant() != _firstRightHasPlant) return false;
            return pot.TwoRightHasPlant() == _secondRightHasPlant;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TH.AdventOfCode._2018.Day12
{
    public class LifeCyclePotrow
    {
        private PotRow _currentPotRow;        
        
        public LifeCyclePotrow(string initial, IEnumerable<string> spreadCombinations)
        {
            _currentPotRow = new PotRow(0, initial, spreadCombinations);           
            File.AppendAllLines("out.txt", new[]{_currentPotRow.CurrentState});
            Console.WriteLine(_currentPotRow.CurrentState);
        }

        public void MoveGenerationsForward(long generations = 1)
        {
            for (long i = 0; i < generations; i++)
            {
                _currentPotRow = _currentPotRow.NextGeneration();
                if (i % 100 == 0)
                {
                    Console.WriteLine($"At generation {i} number of plants {_currentPotRow.CurrentNumberOfPlants}");
                    Console.WriteLine(_currentPotRow.CurrentState);
                } 
            }
        }
        
        public int GenerationCylce 
        {
            get
            {
                var states = new Dictionary<string, List<string>>();
                var count = 1;
                while (true)
                {
                    var state = _currentPotRow.CurrentState.Trim('.');
                    if (!states.ContainsKey(state))
                    {
                        states.Add(state, new List<string>());
                    }
                    states[state].Add($"{count} - {_currentPotRow.CurrentSumOfPlantContainingPots}");
                    count++;
                    _currentPotRow = _currentPotRow.NextGeneration();
                    if (states[state].Count > 1000)
                    {
                        break;
                    }
                }

                
                File.WriteAllLines("Data.txt", states.Select(s => $"{string.Join(Environment.NewLine, s.Value)}  -- {s.Key}"));
                
                return count;
            }
        } 

        public string CurrentState => _currentPotRow.CurrentState;
        public int CurrentSumOfPlantContainingPots => _currentPotRow.CurrentSumOfPlantContainingPots;
    }
}
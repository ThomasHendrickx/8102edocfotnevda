using System;
using System.Linq;

namespace TH.AdventOfCode._2018.Day12.Part1
{
    class Program
    {
        static void Main()
        {
            var combinations = Input
                .GrowCombinations
                .Split(',')
                .Where(c => c.Last() == '#')
                .Select(c => c.Substring(0, 5));
            var lifecyclePotRow = new LifeCyclePotrow(Input.InitialState, combinations);
            lifecyclePotRow.MoveGenerationsForward(20);
            
            Console.WriteLine($"A total of {lifecyclePotRow.CurrentSumOfPlantContainingPots} was generated.");
        }
    }
}
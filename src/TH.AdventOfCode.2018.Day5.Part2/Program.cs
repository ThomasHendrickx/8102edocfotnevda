using System;
using System.Collections.Generic;
using System.Linq;
using TH.AdventOfCode._2018.Day5.Part1;

namespace TH.AdventOfCode._2018.Day5.Part2
{
    class Program
    {
        static void Main()
        {
            var polymer = new Polymer(Input.Value);
            var differentMutations = new List<Polymer>(); 
            foreach (var types in polymer.AllTypes)
            {
                var mutation = polymer.WithoutTypes(types);
                mutation.React();
                differentMutations.Add(mutation);
            }
            Console.WriteLine($"Answer: {differentMutations.Select(m => m.Sequence.Length).OrderBy(m => m).First()}");
        }
    }
}
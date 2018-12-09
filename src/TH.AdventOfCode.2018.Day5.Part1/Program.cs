using System;

namespace TH.AdventOfCode._2018.Day5.Part1
{
    class Program
    {
        static void Main()
        {
            var polymer = new Polymer(Input.Value);
            polymer.React();
            Console.WriteLine("Resulting polymer:");
            Console.WriteLine(polymer.Sequence.Length);
        }
    }
}
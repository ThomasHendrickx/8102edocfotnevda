using System;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    class Program
    {
        static void Main()
        {
            var instructions = Input.Value.Split(';').Select(i => new Instruction(i)).ToList();
            var jobOverview = new JobOverview(instructions);
            jobOverview.Execute(out var sequence);
            Console.WriteLine($"Sequence = {sequence}");
        }
    }
}
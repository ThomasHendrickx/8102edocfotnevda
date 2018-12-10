using System;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    class Program
    {
        static void Main()
        {
            var instructions = Input.Value.Split(';').Select(i => new Instruction(i)).ToList();
            var jobs = new InstructionReader(instructions).AllJobs;
            var jobOverview = new JobOverview(jobs);
            jobOverview.Execute(out var sequence);
            Console.WriteLine($"Sequence = {sequence}");
        }
    }
}
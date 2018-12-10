using System;
using System.Linq;
using TH.AdventOfCode._2018.Day7.Part1;

namespace TH.AdventOfCode._2018.Day7.Part2
{
    class Program
    {
        static void Main()
        {
            var instructions = Input.Value.Split(';').Select(i => new Instruction(i)).ToList();
            var jobs = new InstructionReader(instructions).AllJobs;
            var jobAssigner = new JobAssigner(jobs, 5);
            jobAssigner.Execute();
            Console.WriteLine($"It took {jobAssigner.NumberOfTicks} ticks");                       
        }
        
    }
}
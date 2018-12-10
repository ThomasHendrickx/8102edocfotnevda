using System.Text.RegularExpressions;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    public class Instruction
    {
        private static readonly Regex InstructionRegex = new Regex(@"^Step (?<dependency>[a-zA-Z]) must be finished before step (?<task>[a-zA-Z]) can begin.$");
        
        public string Dependency { get; }
        public string Task { get; }
        
        public Instruction(string instruction)
        {
            var match = InstructionRegex.Match(instruction);
            Dependency = match.Groups["dependency"].Value;
            Task = match.Groups["task"].Value;
        }
    }
}
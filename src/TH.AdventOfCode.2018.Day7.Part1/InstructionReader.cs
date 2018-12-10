using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    public class InstructionReader
    {
        private readonly List<Job> _allJobs;

        public List<Job> AllJobs => _allJobs;

        public InstructionReader(List<Instruction> instructions)
        {
            _allJobs = new List<Job>();
            AddInstructions(instructions);
        }

        private void AddInstructions(List<Instruction> instructions)
        {
            foreach (var instruction in instructions)
            {
                AddInstruction(instruction);
            }
        }
        
        private void AddInstruction(Instruction instruction)
        {
            var dependency = Get(instruction.Dependency);
            var job = Get(instruction.Task);
            job.AddDependency(dependency);
        }        
        
        private Job Get(string jobId)
        {
            var job = _allJobs.FirstOrDefault(j => j.Id == jobId);
            if (job == null)
            {
                job = new Job(jobId);
                _allJobs.Add(job);
            }

            return job;
        }
    }
}
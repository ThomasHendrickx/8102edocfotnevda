using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    public class Job
    {
        public string Id { get; }
        public List<Job> Dependencies { get; }
        public bool Done { get; private set; } = false;

        public Job(string name)
        {
            Id = name;
            Dependencies = new List<Job>();
        }

        public void AddDependency(Job job)
        {
            Dependencies.Add(job);
        }

        public void DoJob()
        {
            
            Done = true;
        }

        public bool CanDo => Dependencies.All(d => d.Done);
    }
}
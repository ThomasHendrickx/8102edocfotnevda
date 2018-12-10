using System;
using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    public class Job
    {
        private static readonly Dictionary<string, int> JobSpecificDuration = new Dictionary<string, int>{{"A", 1},{"B", 2},{"C", 3},{"D", 4},{"E", 5},{"F", 6},{"G", 7},{"H", 8},{"I", 9},{"J", 10},{"K", 11},{"L", 12},{"M", 13},{"N", 14},{"O", 15},{"P", 16},{"Q", 17},{"R", 18},{"S", 19},{"T", 20},{"U", 21},{"V", 22},{"W", 23},{"X", 24},{"Y", 25},{"Z", 26}};
        
        public string Id { get; }
        public List<Job> Dependencies { get; }
        public bool Done { get; private set; } = false;
        public int Duration { get; private set; }
        public bool Assigned { get; private set; }

        public Job(string name)
        {
            Id = name;
            Dependencies = new List<Job>();
            Duration = 60 + JobSpecificDuration[name];
        }

        public void AddDependency(Job job)
        {
            Dependencies.Add(job);
        }

        public void DoJob()
        {
            if (Done)
            {
                throw new Exception("Job Already Done...");
            }
            Duration--;
            if (Duration <= 0)
            {
                Done = true;
            }
        }

        public void Assign()
        {
            Assigned = true;
        }
        
        public bool CanDo => !Done && !Assigned && Dependencies.All(d => d.Done);
    }
}
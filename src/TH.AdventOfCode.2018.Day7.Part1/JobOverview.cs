using System.Collections.Generic;
using System.Linq;

namespace TH.AdventOfCode._2018.Day7.Part1
{
    public class JobOverview
    {
        private readonly List<Job> _allJobs;
        
        public JobOverview(List<Job> jobs)
        {
            _allJobs = jobs;
        }

        public void Execute(out string sequence)
        {
            sequence = string.Empty;
            while (_allJobs.Any(j => !j.Done))
            {
                ExecuteNextJob(out var jobName);
                sequence += jobName;
            }
        }

        private void ExecuteNextJob(out string jobName)
        {
            var jobToExecute = _allJobs.Where(j => j.CanDo && !j.Done).OrderBy(j => j.Id).First();
            jobName = jobToExecute.Id;
            jobToExecute.DoJob();
        }
    }
}
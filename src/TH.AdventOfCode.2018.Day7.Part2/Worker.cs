using System;
using TH.AdventOfCode._2018.Day7.Part1;

namespace TH.AdventOfCode._2018.Day7.Part2
{
    public class Worker
    {
        public Guid Id { get; }
        public Job CurrentJob { get; private set; }

        public Worker()
        {
            Id = Guid.NewGuid();
        }

        public void GiveJob(Job newJob)
        {
            CurrentJob = newJob;
        }

        public bool Available => CurrentJob == null;
        
        public void Work()
        {
            if (CurrentJob == null) return;
            
            CurrentJob.DoJob();
            if (CurrentJob.Done)
            {
                CurrentJob = null;
            }

        }
    }
}
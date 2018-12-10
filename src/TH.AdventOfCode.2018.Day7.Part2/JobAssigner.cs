using System;
using System.Collections.Generic;
using System.Linq;
using TH.AdventOfCode._2018.Day7.Part1;

namespace TH.AdventOfCode._2018.Day7.Part2
{
    public class JobAssigner
    {
        private readonly List<Job> _jobs;
        private readonly List<Worker> _workers;

        public int NumberOfTicks = 0;
        
        public JobAssigner(List<Job> jobs, int numberOfWorkers)
        {
            _jobs = jobs;
            _workers = new List<Worker>();
            for (var i = 0; i < numberOfWorkers; i++)
            {
                _workers.Add(new Worker());
            }
        }

        public void Execute()
        {
            while (_jobs.Any(j => !j.Done))
            {                
                var jobs = _jobs.Where(job => job.CanDo).OrderBy(job => job.Id).ToList();
                var workers = _workers.Where(worker => worker.Available).ToList();
                for (var i = 0; i < Math.Min(jobs.Count, workers.Count); i++)
                {
                    workers[i].GiveJob(jobs[i]);
                    jobs[i].Assign();
                }

                foreach (var worker in _workers)
                {
                    worker.Work();
                }
                
                Console.WriteLine($"{NumberOfTicks} {_workers[0].CurrentJob?.Id ?? "."}  {_workers[1].CurrentJob?.Id ?? "."}  {_workers[2].CurrentJob?.Id ?? "."}  {_workers[3].CurrentJob?.Id ?? "."}  {_workers[4].CurrentJob?.Id ?? "."}");
                NumberOfTicks++;
            }
        }
        
    }
}
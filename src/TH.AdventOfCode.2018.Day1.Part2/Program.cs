using System;
using System.Collections.Generic;

namespace TH.AdventOfCode._2018.Day1.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program(args).Run();
        }

        private readonly Arguments _args;

        private Program(string[] args)
        {
            _args = new Arguments(args);
        }

        private void Run()
        {            
            var values = CommaSeperatedValues.FromString(_args.GetSequence());
            var sequence = FrequencyChangeSequence.FromCommaSeperatedValues(values);
            var frequency = Frequency.StartFromZero();
            var frequencyFound = false;
            var allFrequencyValues = new List<int>();
            while (!frequencyFound)
            {
                foreach (var change in sequence.Changes)
                {
                    frequency.Add(change);
                    if (allFrequencyValues.Contains(frequency.FrequencyNumber))
                    {
                        Console.WriteLine($"Found it! {frequency.FrequencyNumber}");
                        frequencyFound = true;
                        break;
                    }

                    allFrequencyValues.Add(frequency.FrequencyNumber);
                }
            }
        }
    }    
    
    class Arguments
    {
        private readonly string[] _args;
        
        public Arguments(string[] args)
        {
            _args = args;
        }

        public string GetSequence()
        {
            return string.Join(" ", _args);
        }
    }
}
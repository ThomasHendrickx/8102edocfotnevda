using System;

namespace TH.AdventOfCode._2018.Day1.Part1
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
            frequency.Add(sequence);
            
            Console.WriteLine($"The resulting frequency is {frequency.FrequencyNumber}");
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

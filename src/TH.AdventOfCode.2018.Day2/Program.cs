using System;
using System.Linq;

namespace TH.AdventOfCode._2018.Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = args[0].Split(',');
            var ids = x.Select(y => new BoxId(y)).ToList();
            var checksum = new CheckSum(ids);
            Console.WriteLine($"Result = {checksum.Result}");
        }
    }
}
using System;
using System.Linq;
using TH.AdventOfCode._2018.Day3.Part1;

namespace TH.AdventOfCode._2018.Day3.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var claims = string.Join(" ",args).Split(';').Select(c => new Claim(c));
            var cloth = new Cloth();
            foreach (var claim in claims)
            {
                cloth.AddClaim(claim);
            }
            
            Console.WriteLine($"Claims that are unique: {string.Join(", ", cloth.ClaimsWithoutOverlap())}");
        }
    }
}
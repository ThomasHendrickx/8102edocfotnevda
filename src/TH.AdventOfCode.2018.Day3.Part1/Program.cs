using System;
using System.Linq;

namespace TH.AdventOfCode._2018.Day3.Part1
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
            
            Console.WriteLine($"Number of multiple claim pieces of cloth: {cloth.NumberOfCellsWithMultipleClaims()}");
        }
    }
}
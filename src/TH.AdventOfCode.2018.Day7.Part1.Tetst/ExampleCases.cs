using System.Linq;
using Xunit;

namespace TH.AdventOfCode._2018.Day7.Part1.Tetst
{
    public class ExampleCases
    {
        [Fact]
        public void Case1()
        {
            // Arrange
            var instructions =
                "Step C must be finished before step A can begin.;Step C must be finished before step F can begin.;Step A must be finished before step B can begin.;Step A must be finished before step D can begin.;Step B must be finished before step E can begin.;Step D must be finished before step E can begin.;Step F must be finished before step E can begin."
                    .Split(';')
                    .Select(i => new Instruction(i))
                    .ToList();
            var jobOverview = new JobOverview(instructions);

            // Act
            jobOverview.Execute(out var sequence);

            // Assert
            Assert.Equal("CABDFE", sequence);
        }
    }
}
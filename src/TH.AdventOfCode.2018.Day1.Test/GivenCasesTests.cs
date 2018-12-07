using Xunit;

namespace TH.AdventOfCode._2018.Day1.Test
{
    public class GivenCasesTests
    {
        // Start: 0
        // Sequence: 2: +1, -2, +3, +1
        // ShouldBe: 3
        [Fact]
        public void Case1()
        {
            // Arrange
            var sequenceInput = "+1, -2, +3, +1";
            var result = 3;
            
            // Act
            var values = CommaSeperatedValues.FromString(sequenceInput);
            var sequence = FrequencyChangeSequence.FromCommaSeperatedValues(values);
            var frequency = Frequency.StartFromZero();
            frequency.Add(sequence);

            // Assert
            Assert.Equal(result, frequency.FrequencyNumber);
        }
        
        // Start: 0
        // Sequence: 2: +1, +1, +1
        // ShouldBe: 3
        [Fact]
        public void Case2()
        {
            // Arrange
            var sequenceInput = "+1, +1, +1";
            var result = 3;
            
            // Act
            var values = CommaSeperatedValues.FromString(sequenceInput);
            var sequence = FrequencyChangeSequence.FromCommaSeperatedValues(values);
            var frequency = Frequency.StartFromZero();
            frequency.Add(sequence);

            // Assert
            Assert.Equal(result, frequency.FrequencyNumber);
        }
        
        // Start: 0
        // Sequence: 2: +1, +1, -2
        // ShouldBe: 0
        [Fact]
        public void Case3()
        {
            // Arrange
            var sequenceInput = "+1, +1, -2";
            var result = 0;
            
            // Act
            var values = CommaSeperatedValues.FromString(sequenceInput);
            var sequence = FrequencyChangeSequence.FromCommaSeperatedValues(values);
            var frequency = Frequency.StartFromZero();
            frequency.Add(sequence);

            // Assert
            Assert.Equal(result, frequency.FrequencyNumber);
        }
        
        // Start: 0
        // Sequence: 2: -1, -2, -3
        // ShouldBe: -6
        [Fact]
        public void Case4()
        {
            // Arrange
            var sequenceInput = "-1, -2, -3";
            var result = -6;
            
            // Act
            var values = CommaSeperatedValues.FromString(sequenceInput);
            var sequence = FrequencyChangeSequence.FromCommaSeperatedValues(values);
            var frequency = Frequency.StartFromZero();
            frequency.Add(sequence);

            // Assert
            Assert.Equal(result, frequency.FrequencyNumber);
        }
    }
}
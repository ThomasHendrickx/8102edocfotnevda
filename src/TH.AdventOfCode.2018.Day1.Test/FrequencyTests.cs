using Xunit;

namespace TH.AdventOfCode._2018.Day1.Test
{
    public class FrequencyTests
    {

        [Fact]
        public void Should_HaveFrequencyZero_When_StartingFromZeroWithoutChanges()
        {
            // Arrange
            
            
            // Act
            var frequency = Frequency.StartFromZero();
            
            // Assert
            Assert.NotNull(frequency);
            Assert.Equal(0, frequency.FrequencyNumber);
        }
        
        [Fact]
        public void Should_HaveFrequencySameAGivenStart_When_CreatingFrequencyWithIntergerStart()
        {
            // Arrange
            var start = 3452345;
            
            // Act
            var frequency = Frequency.StartFromInteger(start);
            
            // Assert
            Assert.NotNull(frequency);
            Assert.Equal(start, frequency.FrequencyNumber);
        }
        
        [Fact]
        public void Should_HaveFrequencySameAsFrequencyItStartsFrom_When_StartingFromOtherFrequency()
        {
            // Arrange
            var initialFrequency = Frequency.StartFromInteger(64534);
            
            // Act
            var frequency = Frequency.StartFromFrequency(initialFrequency);
            
            // Assert
            Assert.NotNull(frequency);
            Assert.Equal(initialFrequency.FrequencyNumber, frequency.FrequencyNumber);
        }

        [Fact]
        public void Should_HaveFrequencyNumberThatIsEqualToStartPlusChange_When_ApplyingOneChange()
        {
            // Arrange
            var start = 7683;
            var change = FrequencyChange.FromStringInput("+5");
            var frequency = Frequency.StartFromInteger(start);
            
            // Act
            frequency.Add(change);
            
            // Assert
            Assert.Equal(start + change.Change, frequency.FrequencyNumber);
        }
    }
}
using System;
using Xunit;

namespace TH.AdventOfCode._2018.Day1.Test
{
    public class FrequencyChangeTests
    {
        [Fact]
        public void Should_ThrowArgumentException_When_GivingANullChange()
        {
            // Arrange
            string change = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FrequencyChange.FromStringInput(change));
        }
        
        [Fact]
        public void Should_ThrowArgumentException_When_GivingANonIntegerString()
        {
            // Arrange
            const string change = "adasad";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => FrequencyChange.FromStringInput(change));
        }
        
        
        [Fact]
        public void Should_GiveTheIntegerFormOfTheChange_When_GivingCorrectPositiveIntegerString()
        {
            // Arrange
            var changeInt = 123;
            var change = changeInt.ToString();

            // Act
            var frequencyChange = FrequencyChange.FromStringInput(change);
            
            // Assert
            Assert.NotNull(frequencyChange);
            Assert.Equal(changeInt, frequencyChange.Change);
        }
        
        [Fact]
        public void Should_GiveTheIntegerFormOfTheChange_When_GivingCorrectPositiveIntegerStringWithPlusSign()
        {
            // Arrange
            var changeInt = 123;
            var change = $"+{changeInt}";

            // Act
            var frequencyChange = FrequencyChange.FromStringInput(change);
            
            // Assert
            Assert.NotNull(frequencyChange);
            Assert.Equal(changeInt, frequencyChange.Change);
        }
        
        
        [Fact]
        public void Should_GiveTheIntegerFormOfTheChange_When_GivingCorrectNegativeIntegerString()
        {
            // Arrange
            var changeInt = -123;
            var change = changeInt.ToString();

            // Act
            var frequencyChange = FrequencyChange.FromStringInput(change);
            
            // Assert
            Assert.NotNull(frequencyChange);
            Assert.Equal(changeInt, frequencyChange.Change);
        }
    }
}
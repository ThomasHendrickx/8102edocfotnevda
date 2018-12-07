using System;
using Xunit;

namespace TH.AdventOfCode._2018.Day4.Part1.Test
{
    public class TimeEntryTests
    {
        [Fact]
        public void Case01()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 00:00] Guard #10 begins shift";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 00, 00, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.BeginShift, timeEntry.TimeEntryType);
            Assert.Equal(10, timeEntry.Guard);
        }

        [Fact]
        public void Case02()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 00:05] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 00, 05, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case03()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 00:25] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 00, 25, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case04()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 00:30] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 00, 30, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case05()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 00:55] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 00, 55, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case06()
        {
            //  Arrange
            var timeEntryString = "[1518-11-01 23:58] Guard #99 begins shift";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 01, 23, 58, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.BeginShift, timeEntry.TimeEntryType);
            Assert.Equal(99, timeEntry.Guard);
        }

        [Fact]
        public void Case07()
        {
            //  Arrange
            var timeEntryString = "[1518-11-02 00:40] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 02, 00, 40, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case08()
        {
            //  Arrange
            var timeEntryString = "[1518-11-02 00:50] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 02, 00, 50, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case09()
        {
            //  Arrange
            var timeEntryString = "[1518-11-03 00:05] Guard #10 begins shift";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 03, 00, 05, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.BeginShift, timeEntry.TimeEntryType);
            Assert.Equal(10, timeEntry.Guard);
        }

        [Fact]
        public void Case10()
        {
            //  Arrange
            var timeEntryString = "[1518-11-03 00:24] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 03, 00, 24, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case11()
        {
            //  Arrange
            var timeEntryString = "[1518-11-03 00:29] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 03, 00, 29, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case12()
        {
            //  Arrange
            var timeEntryString = "[1518-11-04 00:02] Guard #99 begins shift";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 04, 00, 02, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.BeginShift, timeEntry.TimeEntryType);
            Assert.Equal(99, timeEntry.Guard);
        }

        [Fact]
        public void Case13()
        {
            //  Arrange
            var timeEntryString = "[1518-11-04 00:36] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 04, 00, 36, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case14()
        {
            //  Arrange
            var timeEntryString = "[1518-11-04 00:46] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 04, 00, 46, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case15()
        {
            //  Arrange
            var timeEntryString = "[1518-11-05 00:03] Guard #99 begins shift";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 05, 00, 03, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.BeginShift, timeEntry.TimeEntryType);
            Assert.Equal(99, timeEntry.Guard);
        }

        [Fact]
        public void Case16()
        {
            //  Arrange
            var timeEntryString = "[1518-11-05 00:45] falls asleep";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 05, 00, 45, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.StartAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }

        [Fact]
        public void Case17()
        {
            //  Arrange
            var timeEntryString = "[1518-11-05 00:55] wakes up";

            // Act
            var timeEntry = new TimeEntry(timeEntryString);

            // Assert
            Assert.Equal(new DateTime(1518, 11, 05, 00, 55, 0), timeEntry.TimeStamp.AsDateTime());
            Assert.Equal(TimeEntryTypes.EndAsleep, timeEntry.TimeEntryType);
            Assert.Equal(null, timeEntry.Guard);
        }
    }
}
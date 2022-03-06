using MarsRover.HelperMethods;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarsRover.UnitTest
{
    public class MarsRoverTest
    {
        [Fact]
        public void RoverTestSuccess()
        {
            var roverPos = Helpers.GetRoverPosition(new List<string>() { "1", "2", "N" });
            var plateau = Helpers.GetPlateau(new List<string>() { "5", "5" });
            var commands = "LMLMLMLMM";
            Rover rover = new Rover(roverPos, plateau);
            rover.ExecuteCommands(commands);
            Assert.Equal("1 3 N", rover.GetCurrentPosition());
        }

        [Fact]
        public void RoverTestSuccess2()
        {
            var roverPos = Helpers.GetRoverPosition(new List<string>() { "3", "3", "E" });
            var plateau = Helpers.GetPlateau(new List<string>() { "5", "5" });
            var commands = "MMRMMRMRRM";
            Rover rover = new Rover(roverPos, plateau);
            rover.ExecuteCommands(commands);
            Assert.Equal("5 1 E", rover.GetCurrentPosition());
        }

        [Fact]
        public void RoverTestWrongDataExeption()
        {
            var roverPos = Helpers.GetRoverPosition(new List<string>() { "3", "3", "E" });
            var plateau = Helpers.GetPlateau(new List<string>() { "5", "5" });
            var commands = "123MMRMMRMRRM";
            Rover rover = new Rover(roverPos, plateau);
            Assert.Throws<ArgumentException>(() => rover.ExecuteCommands(commands));
        }
        [Fact]
        public void RoverTestWrongDataExeption2()
        {
            var roverPos = Helpers.GetRoverPosition(new List<string>() { "E", "3", "3" });
            var plateau = Helpers.GetPlateau(new List<string>() { "5", "5" });
            var commands = "MMRMMRMRRM";
            Rover rover = new Rover(roverPos, plateau);
            Assert.Throws<NullReferenceException>(() => rover.ExecuteCommands(commands));
        }
    }
}

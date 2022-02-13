//UnitTest.cs
using System.Collections.Generic;

using Xunit;

namespace TestApp
{
    public class MarsRoverBaseTest
    {
        [Fact]
        public void TestMarsRoverApp()
        {
            Coordinate plateu = new Coordinate(5, 5);
            Coordinate roverOne = new Coordinate(1, 3);
            string expectedOutput = "2 3 E";
            List<Rover> roverList = new List<Rover>();
            var rover = new Rover(roverOne, "W", plateu, "LLM");
            var roverCopy = new Rover(roverOne, "W", plateu, "LLM");
            roverList.Add(rover);
            var RoverMovement = new RoverMovement();
            RoverMovement.Run(roverList);

            Assert.NotNull(rover.GetPosition());
            Assert.NotSame(rover, roverCopy);
            Assert.Equal(rover.GetPosition(), expectedOutput);
        }
    }
}
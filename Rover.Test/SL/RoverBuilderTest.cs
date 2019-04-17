using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rover.SL.Implementation;

namespace Rover.Test.SL
{
    [TestClass]
    public class RoverBuilderTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void InitializeCoordinatesWithNullRobotShouldThrowException()
        {
            var roverBuilder = new RoverBuilder();
            roverBuilder.InitializeCoordinates();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void InitializeOrientationWithNullRobotShouldThrowException()
        {
            var roverBuilder = new RoverBuilder();
            roverBuilder.InitializeCardinalOrientation();
        }

        [TestMethod]        
        public void GetRobotWithNoInitializationShouldBeNull()
        {
            var roverBuilder = new RoverBuilder();
            Assert.IsNull(roverBuilder.GetRover());
        }
    }
}

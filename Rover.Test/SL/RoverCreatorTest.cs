using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rover.BO;
using Rover.SL.Implementation;

namespace Rover.Test.SL
{
    [TestClass]
    public class RoverCreatorTest
    {
        [TestMethod]
        public void RoverCreatorShouldNotBeNull()
        {
            var Creator = new RoverCreator(new RoverBuilder());
            Assert.IsNotNull(Creator.CreateRover());
        }

        [TestMethod]
        [DataRow(CardinalPoint.North,0,0)]
        public void RoverCreatorCreateShouldBeEqual(CardinalPoint facing,int coordX, int coordY)
        {
            var Creator = new RoverCreator(new RoverBuilder());
            var rover = Creator.CreateRover();
            Assert.AreEqual(rover.FacingTo, facing);
            Assert.AreEqual(rover.Position.CoordX, coordX);
            Assert.AreEqual(rover.Position.CoordY, coordY);
        }
    }
}

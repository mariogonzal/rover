using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.BO;
using Rover.BO.Implementation;

namespace Rover.Test.BO
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]        
        [DataRow("Rover is now at 0, 0 - facing North")]
        public void RobotToStringShoudlBeEqual(string expectedValue)
        {
            var r = new Robot {
                Position = new CoordinatePoint {
                     CoordX= 0,
                      CoordY=0
                },
                 FacingTo= CardinalPoint.North

            };
            Assert.AreEqual(r.ToString(), expectedValue);
        }

       


    }
}

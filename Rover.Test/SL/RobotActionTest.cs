using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rover.BO;
using Rover.BO.Implementation;
using Rover.BO.Interfaces;
using Rover.SL;
using Rover.SL.Implementation;
using Rover.SL.Interfaces;

namespace Rover.Test.SL
{
    [TestClass]
    public class RobotActionTest
    {

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void MoveForwardShouldThrowExceptionWithNullRobot()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            IRobot rover = null;
            robotAction.MoveForward(rover);

        }


        [TestMethod]
        [DataRow(CardinalPoint.North, CardinalPoint.East)]
        [DataRow(CardinalPoint.East, CardinalPoint.South)]
        [DataRow(CardinalPoint.South, CardinalPoint.West)]
        [DataRow(CardinalPoint.West, CardinalPoint.North)]
        public void RoverShouldTurnRight(CardinalPoint InitialPoint, CardinalPoint ExpectedCardinalPoint)
        {
            Mock<IRoverCreator> roverCreator = new Mock<IRoverCreator>();
            roverCreator.Setup(x => x.CreateRover()).Returns(new Robot
            {
                FacingTo = InitialPoint,
                Position = new CoordinatePoint
                {
                    CoordX = 0,
                    CoordY = 0
                }
            });
            var rover = roverCreator.Object.CreateRover();
            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            robotAction.TurnRight(rover);
            Assert.AreEqual(rover.FacingTo, ExpectedCardinalPoint);

        }

        [TestMethod]
        [DataRow(CardinalPoint.North, CardinalPoint.West)]
        [DataRow(CardinalPoint.West, CardinalPoint.South)]
        [DataRow(CardinalPoint.South, CardinalPoint.East)]
        [DataRow(CardinalPoint.East, CardinalPoint.North)]
        public void RoverShouldTurnLeft(CardinalPoint InitialPoint, CardinalPoint ExpectedCardinalPoint)
        {
            Mock<IRoverCreator> roverCreator = new Mock<IRoverCreator>();
            roverCreator.Setup(x => x.CreateRover()).Returns(new Robot
            {
                FacingTo = InitialPoint,
                Position = new CoordinatePoint
                {
                    CoordX = 0,
                    CoordY = 0
                }
            });
            var rover = roverCreator.Object.CreateRover();
            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            robotAction.TurnLeft(rover);
            Assert.AreEqual(rover.FacingTo, ExpectedCardinalPoint);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TurnLeftShouldThrowExceptionWithNullRobot()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            IRobot rover = null;
            robotAction.TurnLeft(rover);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TurnRightShouldThrowExceptionWithNullRobot()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            IRobot rover = null;
            robotAction.TurnRight(rover);

        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void PrintRobotInMapThroExceptionWithNullRobot()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            IRobot rover = null;
            robotAction.PrintRobotInMap(rover);

        }

        [ExpectedException(typeof(NullReferenceException))]
        public void PrintRobotInMapThroExceptionWithRobotPointPositionNull()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            var rover = new Robot
            {
                FacingTo = CardinalPoint.South
            };
            robotAction.PrintRobotInMap(rover);

        }

        [ExpectedException(typeof(NullReferenceException))]
        public void PrintRobotInMapThroExceptionWithRobotCardinalPositionNull()
        {

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            var rover = new Robot
            {
                Position = new CoordinatePoint()
            };
            robotAction.PrintRobotInMap(rover);

        }



        [TestMethod]
        [DataRow(0, 0, CardinalPoint.North)]
        [DataRow(0, 1, CardinalPoint.North)]
        [DataRow(0, 2, CardinalPoint.North)]
        [DataRow(0, 3, CardinalPoint.North)]
        [DataRow(0, 4, CardinalPoint.North)]
        [DataRow(0, 0, CardinalPoint.West)]
        [DataRow(1, 0, CardinalPoint.West)]
        [DataRow(2, 0, CardinalPoint.West)]
        [DataRow(3, 0, CardinalPoint.West)]
        [DataRow(4, 0, CardinalPoint.West)]
        [DataRow(0, 4, CardinalPoint.East)]
        [DataRow(1, 4, CardinalPoint.East)]
        [DataRow(2, 4, CardinalPoint.East)]
        [DataRow(3, 4, CardinalPoint.East)]
        [DataRow(4, 4, CardinalPoint.East)]
        [DataRow(4, 0, CardinalPoint.South)]
        [DataRow(4, 1, CardinalPoint.South)]
        [DataRow(4, 2, CardinalPoint.South)]
        [DataRow(4, 3, CardinalPoint.South)]
        [DataRow(4, 4, CardinalPoint.South)]
        public void RoverShouldNotMoveInBorders(int coordX, int coordY, CardinalPoint cardinalPoint)
        {

            var roverStatic = new Robot
            {
                Position = new CoordinatePoint
                {
                    CoordX = coordX,
                    CoordY = coordY
                },
                FacingTo = cardinalPoint
            };

            var roverMoving = new Robot
            {
                Position = new CoordinatePoint
                {
                    CoordX = coordX,
                    CoordY = coordY
                },
                FacingTo = cardinalPoint
            };

            var robotAction = new RobotAction(new RoverCreator(new RoverBuilder()));
            robotAction.MoveForward(roverMoving);
            Assert.AreEqual(roverStatic.FacingTo, roverMoving.FacingTo);
            Assert.AreEqual(roverStatic.Position.CoordX, roverMoving.Position.CoordX);
            Assert.AreEqual(roverStatic.Position.CoordY, roverMoving.Position.CoordY);


        }

    }
}

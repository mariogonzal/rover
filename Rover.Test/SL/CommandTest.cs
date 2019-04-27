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
    public class CommandTest
    {

        [TestMethod]
        public void CommandShuoldNotBeNull()
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            //var command = new Command(roverService.Object);
            //Assert.IsNotNull(command);
        }

        [TestMethod]
        [DataRow("a")]
        [DataRow("1")]
        [DataRow(null)]
        [ExpectedException(typeof(Exception))]
        public void ValidateCommandShouldThrowException(string commandText)
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            //var command = new Command(roverService.Object);
            //command.ValidateCommand(commandText);
        }

        [TestMethod]
        [DataRow("F")]
        [DataRow("L")]
        [DataRow("R")]
        public void ValidateCommandShouldNOTThrowException(string commandText)
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            //var command = new Command(roverService.Object);
            //command.ValidateCommand(commandText);
        }

        [TestMethod]
        [DataRow("F")]
        [DataRow("L")]
        [DataRow("R")]
        public void ExecuteCommandShouldNOTThrowException(string commandText)
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            //var command = new Command(roverService.Object);
            var rover = new Robot();
            //command.ExecuteCommand(rover, commandText);
        }

        [TestMethod]
        [DataRow("t")]
        [DataRow("c")]
        [DataRow(null)]
        [ExpectedException(typeof(Exception))]
        public void ExecuteCommandShouldThrowException(string commandText)
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            //var command = new Command(roverService.Object);
            var rover = new Robot();
            //command.ExecuteCommand(rover, commandText);
        }

        [TestMethod]
        [DataRow("F")]
        [DataRow("L")]
        [DataRow("R")]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void ExecuteWithNullRobotCommandShouldThrowException(string commandText)
        {
            Mock<IRobotAction> roverService = new Mock<IRobotAction>();
            IRobot rover = null;
            //roverService.Setup(x => x.MoveForward(rover)).Throws<NullReferenceException>();
            //roverService.Setup(x => x.TurnLeft(rover)).Throws<NullReferenceException>();
            //roverService.Setup(x => x.TurnRight(rover)).Throws<NullReferenceException>();
            //var command = new Command(roverService.Object);
            //command.ExecuteCommand(rover, commandText);
        }
        

         
    }
}

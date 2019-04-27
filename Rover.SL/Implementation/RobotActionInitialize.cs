using Rover.BO.Interfaces;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RobotActionInitialize : IRobotAction
    {

        private readonly IRoverCreator roverCreator;

        public RobotActionInitialize(IRoverCreator RoverCreator)
        {
            roverCreator = RoverCreator;
        }       
       

        public IRobot Excecute( IRobot rover)
        {
            rover =roverCreator.CreateRover();
            return rover;
        }
    }
}

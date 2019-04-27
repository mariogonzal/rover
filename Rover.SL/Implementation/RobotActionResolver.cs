using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RobotActionResolver : IRobotActionResolver
    {
        private readonly IRoverCreator roverCreator;

        public RobotActionResolver(IRoverCreator roverCreator)
        {
            this.roverCreator = roverCreator;
        }
        public IRobotAction GetRobotAction(string commandInstruction)
        {
            switch (commandInstruction)
            {
                case "F":
                    return new RobotActionMoveForward();
                    
                case "L":
                    return new RobotActionTurnLeft();                    
                case "R":
                    return new RobotActionTurnRight();
                case "I":
                    return new RobotActionInitialize(roverCreator);
                case "P":
                    return new RobotActionPrintRobotInMap();
                default:
                    return null;
                    
            }
        }
    }
}

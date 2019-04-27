using Rover.BO;
using Rover.BO.Implementation;
using Rover.BO.Interfaces;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class Command : ICommand
    {
        private IRobotAction robotAction;
        private readonly IRobotActionResolver robotActionResolver;

        private IRobot rover;

        public Command(IRobotActionResolver robotActionResolver)
        {
            this.robotActionResolver = robotActionResolver;
        }

        public IRobot ExecuteCommand(IRobot rover, string commandText)
        {
            ValidateCommand(commandText);
            robotAction = robotActionResolver.GetRobotAction(commandText);
            return robotAction.Excecute( rover);

        }
       

        public void ValidateCommand(string commandText)
        {
            if (commandText != "L" && commandText != "R" && commandText != "F")
                throw new Exception("invalid command");
        }
    }
}

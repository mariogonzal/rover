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

        public void ExecuteCommand(IRobot rover, string commandText)
        {
            ValidateCommand(commandText);
            robotAction = robotActionResolver.GetRobotAction(commandText);
            robotAction.Excecute(ref rover);

        }

        public void ReadCommand()
        {
            robotActionResolver.GetRobotAction("I").Excecute(ref rover);
            robotActionResolver.GetRobotAction("P").Excecute(ref rover);            
            while (true)
            {
                var commandtxt = Console.ReadLine();
                try
                {
                    ExecuteCommand(rover, commandtxt);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                robotActionResolver.GetRobotAction("P").Excecute(ref rover);
            }
        }

        public void ValidateCommand(string commandText)
        {
            if (commandText != "L" && commandText != "R" && commandText != "F")
                throw new Exception("invalid command");
        }
    }
}

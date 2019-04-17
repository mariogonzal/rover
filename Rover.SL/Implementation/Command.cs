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
        private readonly IRobotAction robotAction;

        private IRobot rover;

        public Command(IRobotAction robotAction)
        {
            this.robotAction = robotAction;
        }

        public void ExecuteCommand(IRobot rover, string commandText)
        {
            ValidateCommand(commandText);
            switch (commandText)
            {
                case "F":
                    robotAction.MoveForward(rover);
                    break;
                case "L":
                    robotAction.TurnLeft(rover);
                    break;
                case "R":
                    robotAction.TurnRight(rover);
                    break;
            }
        }

        public void ReadCommand()
        {
            rover = robotAction.Initialize();
            robotAction.PrintRobotInMap(rover);
            while (true)
            {                
                var commandtxt = Console.ReadLine();
                try
                {
                    ExecuteCommand(rover, commandtxt);
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                robotAction.PrintRobotInMap(rover);
            }
        }

        public void ValidateCommand(string commandText)
        {
            if (commandText != "L" && commandText != "R" && commandText != "F")
                throw new Exception("invalid command");
        }
    }
}

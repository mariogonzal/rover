using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Rover.SL;
using Rover.BO;
using Rover.SL.Implementation;
using Rover.SL.Interfaces;
using Rover.BO.Interfaces;

namespace Rover.App
{
    class Program
    {
        private static IRobot rover;
        public static void Main()
        {

            var container = new UnityContainer();
            container.RegisterType<IRobotActionResolver, RobotActionResolver>();
            container.RegisterType<ICommand, Command>();
            container.RegisterType<IRoverBuilder, RoverBuilder>();
            container.RegisterType<IRoverCreator, RoverCreator>();

            var command = container.Resolve<ICommand>();
            var robotActionResolver = container.Resolve<IRobotActionResolver>();
            var printCommand = robotActionResolver.GetRobotAction(((char)CommandEnum.Print).ToString());

            Initialize(robotActionResolver);
            Print(printCommand);
            ReadCommand(command, printCommand);

        }

        private static void ReadCommand(ICommand command, IRobotAction printCommand)
        {
            while (true)
            {
                var commandtxt = Console.ReadLine();
                try
                {
                    rover = command.ExecuteCommand(rover, commandtxt);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                Print(printCommand);
            }
        }

        private static void Print(IRobotAction printCommand)
        {
            rover = printCommand.Excecute(rover);
            Console.WriteLine(rover.FormattedString);
        }

        private static void Initialize(IRobotActionResolver robotActionResolver)
        {
            var initailizeCommand = robotActionResolver.GetRobotAction(((char)CommandEnum.Initialize).ToString());
            rover = initailizeCommand.Excecute(rover);
        }
    }
}


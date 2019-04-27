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

namespace Rover.App
{
    class Program
    {

        public static void Main()
        {            

            var container = new UnityContainer();            
            container.RegisterType<IRobotActionResolver, RobotActionResolver>();
            container.RegisterType<ICommand, Command>();
            container.RegisterType<IRoverBuilder,RoverBuilder>();
            container.RegisterType<IRoverCreator, RoverCreator>();
            var command = container.Resolve<ICommand>();            
            command.ReadCommand();
        }

    }
}


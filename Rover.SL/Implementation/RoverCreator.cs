using Rover.BO.Implementation;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RoverCreator : IRoverCreator
    {

        private readonly IRoverBuilder roverBuilder;

        public RoverCreator(IRoverBuilder RoverBuilder)
        {
            roverBuilder = RoverBuilder;
        }

        public Robot CreateRover()
        {
            roverBuilder.InitializeRobot();
            roverBuilder.InitializeCoordinates();
            roverBuilder.InitializeCardinalOrientation();
            return roverBuilder.GetRover();
        }
    }
}

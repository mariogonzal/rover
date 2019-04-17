using Rover.BO;
using Rover.BO.Implementation;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RoverBuilder : IRoverBuilder
    {
        private Robot rover;
        public Robot GetRover()
        {
            return rover;
        }

        public void InitializeCardinalOrientation()
        {
            rover.FacingTo = CardinalPoint.North;
        }

        public void InitializeCoordinates()
        {
            rover.Position = new CoordinatePoint
            {
                CoordX = 0,
                CoordY = 0
            };
        }

        public void InitializeRobot()
        {
            rover = new Robot();
        }
    }
}

using Rover.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.BO.Implementation
{
    public class Robot : IRobot
    {        

        public ICoordinatePoint Position { get; set; }
        public CardinalPoint FacingTo { get; set; }
        public string FormattedString { get; set; }

        public Robot()
        {            
        }     

        public override string ToString()
        {
            return ($"Rover is now at {Position.CoordX}, {Position.CoordY} - facing {FacingTo}");
        }
    }
}

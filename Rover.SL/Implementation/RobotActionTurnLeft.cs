using Rover.BO;
using Rover.BO.Interfaces;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RobotActionTurnLeft : IRobotAction
    {
        public void Excecute(ref IRobot rover)
        {
            rover.FacingTo = rover.FacingTo == CardinalPoint.North ? CardinalPoint.West : (CardinalPoint)((int)rover.FacingTo - 1);
            Console.WriteLine(rover.ToString());
        }

       
    }
}

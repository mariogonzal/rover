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
    public class RobotActionMoveForward : IRobotAction
    {
        public void Excecute(ref IRobot rover)
        {
            switch (rover.FacingTo)
            {
                case CardinalPoint.North:
                    if (rover.Position.CoordX > 0)
                        rover.Position.CoordX--;
                    break;
                case CardinalPoint.East:
                    if (rover.Position.CoordY < 4)
                        rover.Position.CoordY++;
                    break;
                case CardinalPoint.South:
                    if (rover.Position.CoordX < 4)
                        rover.Position.CoordX++;
                    break;
                case CardinalPoint.West:
                    if (rover.Position.CoordY > 0)
                        rover.Position.CoordY--;
                    break;
            }

        }

       
    }
}

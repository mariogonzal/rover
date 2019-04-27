using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rover.BO;
using Rover.BO.Implementation;
using Rover.BO.Interfaces;
using Rover.SL.Interfaces;

namespace Rover.SL.Implementation
{
    public class RobotAction //: IRobotAction
    {

        private readonly IRoverCreator roverCreator;

        public RobotAction(IRoverCreator RoverCreator)
        {
            roverCreator = RoverCreator;
        }
        public IRobot Initialize()
        {
            return roverCreator.CreateRover();
        }

        public void MoveForward(IRobot rover)
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

        public void PrintRobotInMap(IRobot rover)
        {
            var instructions = "\nRotate Left : L\nRotate Right: R\nForward: F\n";
            var map = "";

            var roverSign = "(X Y)";
            var pipe = "|";
            var cord = " x,y ";
            for (var x = 0; x <= 4; x++)
                for (var y = 0; y <= 4; y++)
                {
                    if (y == rover.Position.CoordY && x == rover.Position.CoordX)
                        map += roverSign.Replace("X",x.ToString()).Replace("Y",y.ToString()) + pipe;
                    else
                        map += cord.Replace("x", x.ToString()).Replace("y", y.ToString()) + pipe;
                    if (y == 4)                    
                        map += "\n";
                }
            Console.WriteLine(instructions);
            Console.WriteLine(map);
            Console.WriteLine(rover.ToString());
        }

                        
        public void TurnLeft(IRobot rover)
        {
            rover.FacingTo = rover.FacingTo == CardinalPoint.North ? CardinalPoint.West : (CardinalPoint)((int)rover.FacingTo - 1);
            Console.WriteLine(rover.ToString());
        }

        public void TurnRight(IRobot rover)
        {
            rover.FacingTo = rover.FacingTo == CardinalPoint.West ? CardinalPoint.North : (CardinalPoint)((int)rover.FacingTo + 1);
            Console.WriteLine(rover.ToString());
        }
    }
}

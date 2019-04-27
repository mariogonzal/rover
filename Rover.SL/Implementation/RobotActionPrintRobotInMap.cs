using Rover.BO.Interfaces;
using Rover.SL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Implementation
{
    public class RobotActionPrintRobotInMap : IRobotAction
    {
        public IRobot Excecute( IRobot rover)
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
                        map += roverSign.Replace("X", x.ToString()).Replace("Y", y.ToString()) + pipe;
                    else
                        map += cord.Replace("x", x.ToString()).Replace("y", y.ToString()) + pipe;
                    if (y == 4)
                        map += "\n";
                }
            rover.FormattedString=instructions+map+ rover.ToString();            
            return rover;
        }

       
    }
}

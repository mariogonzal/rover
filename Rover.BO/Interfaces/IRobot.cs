using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.BO.Interfaces
{
    public interface IRobot
    {
         ICoordinatePoint Position { get; set; }

        CardinalPoint FacingTo { get; set; }

        string FormattedString { get; set; }


    }
}

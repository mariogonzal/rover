using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.BO.Interfaces
{
    public interface ICoordinatePoint
    {
         int CoordX { get; set; }

         int CoordY { get; set; }
    }
}

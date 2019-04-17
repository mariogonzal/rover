using Rover.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.BO.Implementation
{
    public class CoordinatePoint : ICoordinatePoint
    {
        public int CoordX { get ; set; }
        public int CoordY { get ; set; }
    }
}

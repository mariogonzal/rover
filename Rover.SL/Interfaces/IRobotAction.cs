using Rover.BO;
using Rover.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Interfaces
{
    public interface IRobotAction
    {        

        void MoveForward(IRobot rover);

        void TurnLeft(IRobot rover);

        void TurnRight(IRobot rover);

        IRobot Initialize();

        void PrintRobotInMap(IRobot rover);

    }
}

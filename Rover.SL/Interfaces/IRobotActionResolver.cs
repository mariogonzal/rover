using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Interfaces
{
    public interface IRobotActionResolver
    {
        IRobotAction GetRobotAction(string commandInstruction);
    }
}

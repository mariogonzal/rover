using Rover.BO;
using Rover.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Interfaces
{
    public interface ICommand
    {

        IRobot ExecuteCommand(IRobot rover, string commandText);
        void ValidateCommand(string commandText);
        
    }
}

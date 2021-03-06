﻿using Rover.BO.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.SL.Interfaces
{
    public interface IRoverBuilder
    {
        Robot GetRover();

        void InitializeRobot();

        void InitializeCoordinates();

        void InitializeCardinalOrientation();

    }
}

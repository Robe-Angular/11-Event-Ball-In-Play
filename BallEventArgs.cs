﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event_Ball_In_Play
{
    public class BallEventArgs:EventArgs
    {
        public int Trajectory { get; private set; }
        public int Distance { get; private set; }
        public BallEventArgs(int trajectory, int distance)
        {
            this.Trajectory = trajectory;
            this.Distance = distance;
        }

    }
}

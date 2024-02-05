using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event_Ball_In_Play
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance > 400 && ballEventArgs.Trajectory > 30)
                    tryCatch();
                else
                    screamAndYell();
            }
        }

        private void tryCatch()
        {
            Console.WriteLine("Fan: My oportunity");
        }

        private void screamAndYell()
        {
            Console.WriteLine("Fan: Ohh no, why");
        }
    }
}

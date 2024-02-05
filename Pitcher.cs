using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event_Ball_In_Play
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 65))
                    catchBall();
                else
                    coverFirstBase();

            }
        }
        private void catchBall()
        {
            Console.WriteLine("Pitcher: Ball caught");
        }

        private void coverFirstBase()
        {
            Console.WriteLine("Pitcher: Running to first base");
        }
    }
}

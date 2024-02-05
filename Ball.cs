using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Event_Ball_In_Play
{
    class Ball
    {
        public event EventHandler BallInPlay;

        protected void OnBallInPlay(BallEventArgs e)
        {

            if (BallInPlay != null)
            {
                
                BallInPlay(this, e);
            }
        }

        public Bat GetNewBat()
        {
            return new Bat(OnBallInPlay);
        }
    }
}

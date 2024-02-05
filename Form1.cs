using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Event_Ball_In_Play
{
    public partial class Form1 : Form
    {
        Ball ball;
        Pitcher pitcher;
        Fan fan;
        public Form1()
        {
            InitializeComponent();
            ball = new Ball();
            fan = new Fan(ball);
            pitcher = new Pitcher(ball);
            
        }

        private void inputLabel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs((int)trajectoryInput.Value, (int)distanceInput.Value);
            bat.HitTheBall(ballEventArgs);
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybirdgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int boruhizi = 8, gravity = 9 , score = 0;
        private void gameTimerEvent(object sender, EventArgs e)
        {
            kus.Top += gravity;
            balt.Left -= boruhizi;
            bust.Left -= boruhizi;
            label1.Text = "Score :" + score;
            if (balt.Left < -150)
            {
                balt.Left = 800;
                score++;
            }
            if (bust.Left < -180)
            {
                bust.Left = 950;
                score++;
            }
            if (kus.Bounds.IntersectsWith(balt.Bounds) || kus.Bounds.IntersectsWith(bust.Bounds) || kus.Bounds.IntersectsWith(zemin.Bounds)||kus.Top < -25)
            {
                endgame();
            }
            if (score > 5)
            {
                boruhizi = 12;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -9;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endgame()
        {
            gametimer.Stop();
            label1.Text = "GAME OVER LOO";
        }

    }
}

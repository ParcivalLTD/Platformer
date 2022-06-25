using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Platformer : Form
    {
        bool isJumping = false;

        public Platformer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if(!pbPlayer.Bounds.IntersectsWith(pbGround.Bounds) && isJumping == false)
            {
                pbPlayer.Top += 10; 
            }
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left -= 10;
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            pbPlayer.Top -= 10;
            isJumping = true;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            pbPlayer.Left += 10;
        }

        private void Platformer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrUp.Start();
            } else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Start();
            } else if (e.KeyCode == Keys.Left)
            {
                tmrLeft.Start();
            }
        }

        private void Platformer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrUp.Stop();
                isJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmrLeft.Stop();
            }
        }
    }
    
}

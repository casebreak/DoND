using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DealorNoDeal
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public Welcome(int fire)
        {
            InitializeComponent();


            if (fire == 0)
            {
                this.Visible = true;
                wexit_button.Text = "Continue";
                play_button.Visible = false;
                play_button.Enabled = false;
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 play = new Form1();
            play.BringToFront();
        }

        private void wexit_button_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Visible = false;
        }
    }
}

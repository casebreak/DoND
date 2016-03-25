using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealorNoDeal
{
    public partial class Winnings : Form
    {
        public Winnings(double winnings, double topAverage, double otherCase)
        {
            InitializeComponent();

            winningPayout_lbl.Text = winnings.ToString("C");

            highestOfferNum_lbl.Text = topAverage.ToString("C");

            otherCaseAmount_lbl.Text = otherCase.ToString("C");
        }

        public Winnings(double winnings, double topAverage, string theirCase)
        {
            InitializeComponent();

            winningPayout_lbl.Text = winnings.ToString("C");

            highestOfferNum_lbl.Text = topAverage.ToString("C");

            otherCaseAmount_lbl.Text = theirCase;
            yourCase_lbl.Visible = true;

            //otherCaseAmount_lbl.Visible = false;
            otherCase_lbl.Visible = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }
    }
}

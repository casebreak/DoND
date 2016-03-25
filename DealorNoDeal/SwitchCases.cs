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
    public partial class SwitchCases : Form
    {
        public double pwinnings;
        public double pusersCaseAmount;
        public double ptopOffer;
        public double potherCase;

        public SwitchCases(double winnings, double otherCase, double usersCaseAmount, double topOffer)
        {
            InitializeComponent();

            pwinnings = winnings;
            pusersCaseAmount = usersCaseAmount;
            ptopOffer = topOffer;
            potherCase = otherCase;
        }

        private void switch_button_Click(object sender, EventArgs e)
        {
            pwinnings = potherCase; //winnings set to the value of the other case
            Winnings launchWinnings = new Winnings(pwinnings, ptopOffer, pusersCaseAmount);
            launchWinnings.ShowDialog();
            this.Close();
        }

        private void noSwitch_button_Click(object sender, EventArgs e)
        {
            pwinnings = pusersCaseAmount; //Winnings set to the value of the original case
            Winnings launchWinnings = new Winnings(pwinnings, ptopOffer, potherCase);
            launchWinnings.ShowDialog();
            this.Close();
        }
    }
}

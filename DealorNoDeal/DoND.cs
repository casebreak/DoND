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
    public partial class DoND : Form
    {
        public double pwinnings;
        public double prounds;
        public double poffer;
        public double pusersCaseAmount;
        public double ptopOffer;

        public DoND(int rounds, double winnings, double offer, double usersCaseAmount, double topOffer)
        {
            InitializeComponent();

            pwinnings = winnings;
            prounds = rounds;
            poffer = offer;
            pusersCaseAmount = usersCaseAmount;
            ptopOffer = topOffer;

            currentOfferNumber_lbl.Text = offer.ToString("C");
        }

        private void deal_button_Click(object sender, EventArgs e)
        {
            pwinnings = poffer; //Set winnings to the current offer
            string usersCaseString = pusersCaseAmount.ToString("C"); //Gets passed to Winnings so user can see the amount of their original case
            Winnings launchWinnings = new Winnings(pwinnings, ptopOffer, usersCaseString);
            launchWinnings.ShowDialog();
            this.Close();
            Environment.Exit(0);
        }

        private void noDeal_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

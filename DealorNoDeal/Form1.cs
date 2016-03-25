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
    public partial class Form1 : Form
    {
        //Variables
        public double[] payouts = new double[26] { .01, 1, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        public PictureBox[] pbArray = new PictureBox[26];
        public Label[] labelArray = new Label[26];
        Cases[] cases = new Cases[26];
        public int[] randomArray;
        Random r = new Random();
        public int casesRemaining = 26;
        public int rounds = 0;
        public int numbers;
        public int index;
        public int clicks = 0;
        public int casesToPick = 0;
        public double topOffer = 0;
        public double winnings = 0;
        public double usersCaseAmount;
        public double incentive;      //Varible to determine how much bonus incentive to add to the Banker's offer.

        public Form1()
        {
            InitializeComponent();

            #region Populate Arrays and set values
            //Populate the pbArray (PictureBoxArray) with the picture box cases from the form.
            pbArray = new PictureBox[] { case1, case2, case3, case4, case5, case6, case7, case8, case9, case10,
                case11, case12, case13, case14, case15, case16, case17, case18, case19, case20, case21, case22, case23, case24, case25, case26 };

            //Populate the label array with all 26 payout labels.
            labelArray = new Label[] { payout1_lbl, payout2_lbl, payout3_lbl, payout4_lbl, payout5_lbl, payout6_lbl, payout7_lbl, payout8_lbl,
                payout9_lbl, payout10_lbl, payout11_lbl, payout12_lbl, payout13_lbl, payout14_lbl, payout16_lbl, payout17_lbl, payout18_lbl,
                payout19_lbl, payout20_lbl, payout21_lbl, payout22_lbl, payout23_lbl, payout24_lbl, payout25_lbl, payout26_lbl };

            //Generate a hash set of random numbers between 0-26. Hash set was used here to eliminate duplicates
            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < 26)
            {
                numbers.Add(r.Next(26));
            }
            randomArray = numbers.ToArray();  //Store hash set in an array

            //Assigns a random payout to a random case and assigns the mouse click event argument for each case
            for (int i = 0; i < numbers.Count; i++)
            {
                cases[i] = new Cases(payouts[randomArray[i]], pbArray[randomArray[i]]);
                pbArray[i].Click += new EventHandler(pb_Click);
            }

            #endregion

            //Starts the main flow of the game.
            EliminateCases(rounds);
        }

        public void EliminateCases(int currentRound)
        {
            //Array of phrases to use in the message boxes
            string[] phrases = { "No Deal?! Interesting choice...", "I have a feeling you know what you're doing.", "Looks like we've got a risk taker on our hands!",
                "Confidence will be your downfall!", "Feeling lucky, eh?", "No one likes a greedy person.", "You shall not pass!", "Smells like money in here...",
                "Take two weeks off and quit", "What, the offer wasn't god enough for you?", "Let it ride!", "Quit while you're ahead...Or behind.", "Have you spoken to your financial advisor?",
                "Should have taken the offer...", "Seriously? Wow... alright then...", "Don't push your luck, kid.", "You know you have to pay taxes on your winnings.",
                "Hey, it's your round to lose.", "Still think you've got a shot?", "Sorry, Howie Mandell couldn't make it today.", "The stress must be getting to you!",
                "We've got a badass over here!", "From rags to riches!", "You know you can't take it with you...", "You'll regret that decision!", "Just quit already." };

            switch (currentRound)
            {
                //@ the beginning of each round, re-initializes clicks to 0, make all cases active, 
                //display the appropriate message box with a randomized message (when appropo), and set how many cases to be eliminated.
                case 0:
                    this.Show();    //Displays Form1 before anything else happens.
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show("Please pick your winning case!");
                    casesToPick = 1;
                    break;

                case 1:
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show("Now that you've selected your winning case..." + "\n\n" + "Please pick 6 cases to eliminate", "Round:  " + rounds);
                    casesToPick = 6;
                    this.Text = "Cases to pick this round:   " + casesToPick;
                    break;

                case 2:
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show(phrases[randomArray[r.Next(26)]] + "\n\n" + "Please pick 5 more cases to eliminate", "Round:  " + rounds);
                    casesToPick = 5;
                    this.Text = "Cases to pick this round:   " + casesToPick;
                    break;

                case 3:
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show(phrases[randomArray[r.Next(26)]] + "\n\n" + "Please pick 4 more cases to eliminate", "Round:  " + rounds);
                    casesToPick = 4;
                    this.Text = "Cases to pick this round:   " + casesToPick;
                    break;

                case 4:
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show(phrases[randomArray[r.Next(26)]] + "\n\n" + "Please pick 3 more cases to eliminate", "Round:  " + rounds);
                    casesToPick = 3;
                    this.Text = "Cases to pick this round:   " + casesToPick;
                    break;

                case 5:
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show(phrases[randomArray[r.Next(26)]] + "\n\n" + "Please pick 2 more cases to eliminate", "Round:  " + rounds);
                    casesToPick = 2;
                    this.Text = "Cases to pick this round:   " + casesToPick;
                    break;

                case 10:
                    //Find the last case
                    double otherCase = 0;
                    for (int i = 0; i < pbArray.Length; i++)
                    {
                        if (cases[i].WorkingValue != 0 && cases[i].WorkingValue != 1000)
                        {
                            otherCase = cases[i].Value;
                        }
                    }

                    //Launch the final round/switch cases form
                    SwitchCases switchCases = new SwitchCases(winnings, otherCase, usersCaseAmount, topOffer);
                    switchCases.ShowDialog();
                    break;

                default:    //All of the one-case rounds
                    clicks = 0;
                    ActivateCases();
                    MessageBox.Show(phrases[randomArray[r.Next(26)]] + "\n\n" + "Please pick 1 more case to eliminate", "Round:  " + rounds);
                    casesToPick = 1;
                    break;
            }
        }
        
        //These events fire when a case is clicked
        public void pb_Click(object sender, EventArgs e)
        {
            #region Object and Label modification onClick

            PictureBox clickedPictureBox = sender as PictureBox;
            index = Array.IndexOf(pbArray, clickedPictureBox);      //Get the index of the selected case
            
            if (rounds == 0)    //Initial case selection
            {
                usersCaseAmount = cases[index].Value;
                usersCase_lbl.Visible = true;
                usersCaseNumber_lbl.Visible = true;
                pbArray[index].Image = Image.FromFile("../../Resources/selectedCase.png");

                cases[index].WorkingValue = 1000;   //Set value to 1000 to find it later.
                usersCaseNumber_lbl.Text = pbArray[index].Tag.ToString();   //Display the selected case in the user's case number label
            }

            if (rounds != 0)    //All other case selections beyond the first
            {
                eliminatedCase_lbl.Visible = true;
                eliminatedCaseNumber_lbl.Visible = true;
                eliminatedCaseNumber_lbl.Text = cases[index].Value.ToString("C");
                for (int i = 0; i < labelArray.Length; i++)
                {
                    //Convert case's value and label's tag value to a double. This is done in order to compare both values since leaving them un converted
                    //would spawn an error 'unable to compare an object to a double'. 
                    double labelToDouble = Convert.ToDouble(labelArray[i].Tag);
                    double caseValueToDouble = Convert.ToDouble(cases[index].Value);

                    //Ran into an odd bug. All case/label eliminations were working as expected except the 5000 value case.
                    //I made a special condition to check for the 5000 value and apply the rules specifically to that case/label.
                    if (caseValueToDouble == 5000)
                    {
                        pbArray[index].Image = Image.FromFile("../../Resources/closedCase.png");
                        payout15_lbl.BackColor = Color.Red;
                        cases[index].WorkingValue = 0;
                        cases[index].Value = 0;
                    }

                    //Check to see if case value = label tag value. This action hides the case and it's corresponding payout label.
                    if (caseValueToDouble == labelToDouble)
                    {
                        labelArray[i].BackColor = Color.Red;
                        cases[index].WorkingValue = 0;
                        cases[index].Value = 0;     //Sets the value of the selected case to 0
                        pbArray[index].Image = Image.FromFile("../../Resources/closedCase.png");
                    }
                }
            }
            #endregion

            clicks++;   //This counter will increase each time a case is clicked/selected

            if (clicks >= casesToPick)      //Limits the user to click appropriate number of cases depending on the round.
            {
                DeactiveCases();
                if (rounds != 0)
                {
                    //MessageBox.Show("The Banker is ready to make his offer!");
                    BankOffer(cases, rounds);
                }
                else if (rounds == 0)
                {
                    rounds++;   //Increase round by one
                    EliminateCases(rounds); //Continue eliminating cases
                }
            }
        }

        //This method calculates the Banker's offer.
        private void BankOffer(Cases[] passedCases, int currentRound)
        {
            int countCases = 0;
            double total = 0, average = 0, highest = 0;

            //Find remaining cases
            for (int i = 0; i < cases.Length; i++)
            {
                if (passedCases[i].Value != 0)  //Ensures that only the remaining cases will be calculated into the average
                {
                    double current = passedCases[i].Value;
                    if (current > highest)
                    {
                        highest = current;  //Get value of highest case
                    }
                    total += passedCases[i].Value;
                    countCases++;   //Counts the number of cases remaining
                }
            }
            average = total / countCases;   //Get average of remaining cases. Expected value.

            switch (currentRound)   //Set incentive % based on the current round
            {
                case 1: incentive = .15; break;
                case 2: incentive = .25; break;
                case 3: incentive = .35; break;
                case 4: incentive = .45; break;
                case 5: incentive = .54; break;
                case 6: incentive = .64; break;
                case 7: incentive = .73; break;
                case 8: incentive = .82; break;
                case 9: incentive = .91; break;
                case 10: incentive = .95; break;
            }
            double step1 = average * incentive;
            double step2 = RoundToNearest(step1, 100);  //Get rounded value to nearest $100
            double offer = step2;

            //Banker's offer formula from http://commcognition.blogspot.com/2007/06/deal-or-no-deal-bankers-formula.html
            //double offer = 12275.30 +
            //                (.748 * average) +
            //                (-2714.74 * countCases) +
            //                (-.040 * highest) +
            //                (.0000006986 * (average * average)) +
            //                (32.623 * (countCases * countCases));

            if (offer > topOffer)
            {
                topOffer = offer;   //Track the top banker offer
            }

            currentOffer_lbl.Visible = true;
            currentOfferNumber_lbl.Visible = true;
            currentOfferNumber_lbl.Text = offer.ToString("C");    //Display the current offer on screen

            DoND dealNoDeal = new DoND(rounds, winnings, offer, usersCaseAmount, topOffer);
            dealNoDeal.ShowDialog();

            rounds++;
            EliminateCases(rounds);
        }

        //This method handles the rounding of the banker's offer.
        public static double RoundToNearest(double Amount, double RoundTo)
        {
            double ExcessAmount = Amount % RoundTo;
            if (ExcessAmount < (RoundTo / 2))
            {
                Amount -= ExcessAmount;
            }
            else
            {
                Amount += (RoundTo - ExcessAmount);
            }
            return Amount;
        }

        //Make all cases un clickable
        public void DeactiveCases()
        {
            for (int i = 0; i < pbArray.Length; i++)
            {
                pbArray[i].Enabled = false;
            }
        }

        //Make all cases clickable
        public void ActivateCases()
        {
            for (int i = 0; i < pbArray.Length; i++)
            {
                pbArray[i].Enabled = true;
            }
        }

        //Closes program when menu strip button is selected
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        //Display help/welcome label when menu button is clicked
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Launch help screen with a control variable, preventing certain buttons from appearing on the form
            int fire = 0;
            Welcome help = new Welcome(fire);
        }
    }
}

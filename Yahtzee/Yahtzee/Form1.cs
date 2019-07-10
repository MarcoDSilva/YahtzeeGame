//Yahtzee Game
//made by MarcoSilva
//started at 7 july 2019

using System;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_rollDice_Click(object sender, EventArgs e)
        {
            Rng generator = new Rng();
        
            //passes the dice rng to the respective labels
            if (chk_holdD1.Checked != true)
            {
                lbl_displayDice1.Text = Convert.ToString(generator.DiceRng());
            }
            if (chk_holdD2.Checked != true)
            {
                lbl_displayDice2.Text = Convert.ToString(generator.DiceRng());
            }
            if (chk_holdD3.Checked != true)
            {
                lbl_displayDice3.Text = Convert.ToString(generator.DiceRng());
            }
            if (chk_holdD4.Checked != true)
            {
                lbl_displayDice4.Text = Convert.ToString(generator.DiceRng());
            }
            if (chk_holdD5.Checked != true)
            {
                lbl_displayDice5.Text = Convert.ToString(generator.DiceRng());
            }
          

            higherScoreChecker();
            lowerScoreChecker();
        }
      
        //checks the dice value with the respective score part (aces, twos etc...)
        public int SimpleDices(int checker)
        {
            int counter = 0;

            if (Convert.ToInt32(lbl_displayDice1.Text) == checker) { counter++; }
            if (Convert.ToInt32(lbl_displayDice2.Text) == checker) { counter++; }
            if (Convert.ToInt32(lbl_displayDice3.Text) == checker) { counter++; }
            if (Convert.ToInt32(lbl_displayDice4.Text) == checker) { counter++; }
            if (Convert.ToInt32(lbl_displayDice5.Text) == checker) { counter++; }

            return counter;
        }

        //calls the method that does the conditional that checks the dice, checks all possible combinations
        public void higherScoreChecker()
        {
            //verifies the number of dices from Aces to Sixes score and multiplies it by the respective number if more than one dice
            lbl_aces.Text = Convert.ToString(SimpleDices(1));
            lbl_twos.Text = Convert.ToString(SimpleDices(2) * 2);
            lbl_threes.Text = Convert.ToString(SimpleDices(3) * 3);
            lbl_fours.Text = Convert.ToString(SimpleDices(4) * 4);
            lbl_fives.Text = Convert.ToString(SimpleDices(5) * 5);
            lbl_sixes.Text = Convert.ToString(SimpleDices(6) * 6);
        }

        //method that verifies the bottom part
        //trios, four of a kind, sequences, fh, yahtzee, chances
        public void lowerScoreChecker()
        {
            int dice1 = SimpleDices(1);
            int dice2 = SimpleDices(2);
            int dice3 = SimpleDices(3);
            int dice4 = SimpleDices(4);
            int dice5 = SimpleDices(5);
            int dice6 = SimpleDices(6);

            int dice1_val = Convert.ToInt32(lbl_displayDice1.Text);
            int dice2_val = Convert.ToInt32(lbl_displayDice2.Text);
            int dice3_val = Convert.ToInt32(lbl_displayDice3.Text);
            int dice4_val = Convert.ToInt32(lbl_displayDice4.Text);
            int dice5_val = Convert.ToInt32(lbl_displayDice5.Text);

            //chance
            lbl_scoreChance.Text = Convert.ToString(dice1 + (dice2 * 2) + (dice3 * 3) + (dice4 * 4) + (dice5 * 5) + (dice6 * 6));

            //three of a kind
            if (dice1 >= 3 || dice2 >= 3 || dice3 >= 3 || dice4 >= 3 || dice5 >= 3 || dice6 >= 3)
            {
                lbl_score3Kind.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
            }

            //four of a kind
            if (dice1 >= 4 || dice2 >= 4 || dice3 >= 4 || dice4 >= 4 || dice5 >= 4 || dice6 >= 4)
            {
                lbl_4KindScore.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
            }            

            //lower straights
            if ((dice1 == 1 && dice2 == 2 && dice3 == 3 && dice4 == 4) || (dice1 == 2 && dice2 == 3 && dice3 == 4 && dice4 == 5) ||
                    (dice1 == 3 && dice2 == 4 && dice3 == 5 && dice4 == 6) || (dice2 == 1 && dice3 == 2 && dice4 == 3 && dice5 == 4) ||
                       (dice2 == 2 && dice3 == 3 && dice4 == 4 && dice5 == 5) || (dice2 == 3 && dice3 == 4 && dice4 == 5 && dice5 == 6))
            {
                lbl_scoreLStraight.Text = Convert.ToString(30);
            }

            //large straight
            if ((dice1 == 1 && dice2 == 2 && dice3 == 3 && dice4 == 4 && dice5 == 5) ||
                    dice1 == 2 && dice2 == 3 && dice3 == 4 && dice4 == 5 && dice5 == 6)
            {
                lbl_scoreHStraight.Text = Convert.ToString(40);
            }

            //yahtzee
            if (dice1 >= 5 || dice2 >= 5 || dice3 >= 5 || dice4 >= 5 || dice5 >= 5 || dice6 >= 5)
            {
                lbl_scoreYat.Text = Convert.ToString(50);
            }

            //int conversions for final score
            int acesScore = Convert.ToInt32(lbl_aces.Text);
            int twosScore = Convert.ToInt32(lbl_twos.Text);
            int threeScore = Convert.ToInt32(lbl_threes.Text);
            int fourScore = Convert.ToInt32(lbl_fours.Text);
            int fiveScore = Convert.ToInt32(lbl_fives.Text);
            int sixesScore = Convert.ToInt32(lbl_sixes.Text);

            int threeKind = Convert.ToInt32(lbl_score3Kind.Text);
            int fourKind = Convert.ToInt32(lbl_4KindScore.Text);
            int low_straight = Convert.ToInt32(lbl_scoreLStraight.Text);
            int high_straight = Convert.ToInt32(lbl_scoreHStraight.Text);
            int chance = Convert.ToInt32(lbl_scoreChance.Text);
            int yahtzee_score = Convert.ToInt32(lbl_scoreYat.Text);

            int grandTotal = acesScore + twosScore + threeScore + fourScore + fiveScore + sixesScore + threeKind + fourKind
                        + low_straight + high_straight + chance + yahtzee_score;

            //final score
            lbl_finalScore.Text = Convert.ToString(grandTotal);
        }

        // ----------------- LABEL CLICK EVENTS -----------------
      
        private void label_click_aces(object sender, EventArgs e)
        {
            Label click_aces = sender as Label;

            if(click_aces != null)
            {
                MessageBox.Show("ACES LOCKED!");
            }
        }
        private void label_click_deuces(object sender, EventArgs e)
        {
            Label click_deuces = sender as Label;

            if (click_deuces != null)
            {
                MessageBox.Show("DEUCES LOCKED!");
            }
        }

        private void label_click_threes(object sender, EventArgs e)
        {
            Label click_three = sender as Label;

            if (click_three != null)
            {
                MessageBox.Show("THRES LOCKED!");
            }
        }

        private void label_click_fours(object sender, EventArgs e)
        {
            Label click_fours = sender as Label;

            if (click_fours != null)
            {
                MessageBox.Show("FOURS LOCKED!");
            }
        }

        private void label_click_fives(object sender, EventArgs e)
        {
            Label click_fives = sender as Label;

            if (click_fives != null)
            {
                MessageBox.Show("FIVES LOCKED!");
            }
        }

        private void label_click_sixes(object sender, EventArgs e)
        {
            Label click_sixes = sender as Label;

            if (click_sixes != null)
            {
                MessageBox.Show("SIXES LOCKED!");
            }
        }

        private void label_click_3Kind(object sender, EventArgs e)
        {
            Label click_3kind = sender as Label;

            if (click_3kind != null)
            {
                MessageBox.Show("3WAY LOCKED!");
            }
        }

        private void label_click_4Kind(object sender, EventArgs e)
        {
            Label click_4way = sender as Label;

            if (click_4way != null)
            {
                MessageBox.Show("4WAY LOCKED!");
            }
        }

        private void label_click_FH(object sender, EventArgs e)
        {
            Label click_fh = sender as Label;

            if (click_fh != null)
            {
                MessageBox.Show("FH LOCKED!");
            }
        }

        private void label_click_LS(object sender, EventArgs e)
        {
            Label click_ls = sender as Label;

            if (click_ls != null)
            {
                MessageBox.Show("LS LOCKED!");
            }
        }

        private void label_click_HS(object sender, EventArgs e)
        {
            Label click_hs = sender as Label;

            if (click_hs != null)
            {
                MessageBox.Show("HS LOCKED!");
            }
        }

        private void label_click_chance(object sender, EventArgs e)
        {
            Label click_chance = sender as Label;

            if (click_chance != null)
            {
                MessageBox.Show("CHANCE LOCKED!");
            }

        }

        private void label_click_yahtzee(object sender, EventArgs e)
        {
            Label click_yahtzee = sender as Label;

            if (click_yahtzee != null)
            {
                MessageBox.Show("YAHTZEE LOCKED!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //score
        private void ScoreBox_Enter(object sender, EventArgs e)
        {

        }

        private void LayoutPanel_dices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_rollDice_Click(object sender, EventArgs e)
        {
            Rng generator = new Rng();
            Scores score = new Scores();
        
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

        //label for aces
        private void Lbl_aces_Click(object sender, EventArgs e)
        {
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
            //verifies the number of dices from Aces to Sixes score
            lbl_aces.Text = Convert.ToString(SimpleDices(1));
            lbl_twos.Text = Convert.ToString(SimpleDices(2));
            lbl_threes.Text = Convert.ToString(SimpleDices(3));
            lbl_fours.Text = Convert.ToString(SimpleDices(4));
            lbl_fives.Text = Convert.ToString(SimpleDices(5));
            lbl_sixes.Text = Convert.ToString(SimpleDices(6));

        }

        //method that verifies the bottom part
        //trios, four of a kind, sequences, yahtzee, chances
        public void lowerScoreChecker()
        {
            int dice1 = Convert.ToInt32(lbl_aces.Text);
            int dice2 = Convert.ToInt32(lbl_twos.Text);
            int dice3 = Convert.ToInt32(lbl_threes.Text);
            int dice4 = Convert.ToInt32(lbl_fours.Text);
            int dice5 = Convert.ToInt32(lbl_fives.Text);
            int dice6 = Convert.ToInt32(lbl_sixes.Text);

            int dice1_val = Convert.ToInt32(lbl_displayDice1.Text);
            int dice2_val = Convert.ToInt32(lbl_displayDice2.Text);
            int dice3_val = Convert.ToInt32(lbl_displayDice3.Text);
            int dice4_val = Convert.ToInt32(lbl_displayDice4.Text);
            int dice5_val = Convert.ToInt32(lbl_displayDice5.Text);

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

            //yahtzee
            if (dice1 >= 5 || dice2 >= 5 || dice3 >= 5 || dice4 >= 5 || dice5 >= 5 || dice6 >= 5)
            {
                lbl_scoreYat.Text = Convert.ToString(50);
            }

            //large straight
            if ((dice1 == 1 && dice2 == 2 && dice3 == 3 && dice4 == 4 && dice5 == 5) ||
                    dice1 == 2 && dice2 == 3 && dice3 == 4 && dice4 == 5 && dice5 == 6)
            {
                lbl_scoreHStraight.Text = Convert.ToString(40);
            }

            //lower straights
            if ((dice1 == 1 && dice2 == 2 && dice3 == 3 && dice4 == 4) || (dice1 == 2 && dice2 == 3 && dice3 == 4 && dice4 == 5) ||
                    (dice1 == 3 && dice2 == 4 && dice3 == 5 && dice4 == 6) || (dice2 == 1 && dice3 == 2 && dice4 == 3 && dice5 == 4) ||
                       (dice2 == 2 && dice3 == 3 && dice4 == 4 && dice5 == 5) || (dice2 == 3 && dice3 == 4 && dice4 == 5 && dice5 == 6))
            {
                lbl_scoreLStraight.Text = Convert.ToString(30);
            }
        }
    }
}

//Yahtzee Game
//made by MarcoSilva
//started at 7 july 2019

/*TODO LIST:
 * SEPARATE LOWER SCORE IN TINY METHODS INSTEAD OF ALL BEING INSIDE THE SAME METHOD - working on it
 * REFACTOR some waste of variavels to use the now made arrays, and switch some to arrays as well
 * NEW GAME BUTTON
 * ===========================
 * COUNTER LIMIT OF 3 PLAYS , THEN PLAYER HAS TO LOCK ONE OF THE OPTIONS EVEN WITH 0 POINTS
 * TERMINATING THE GAME AND RETURNING THE FINAL SCORE AS POPUP WHEN ALL 13 OPTIONS ARE USED
 * DESIGN MISC.
 * BOT PLAYER || 2 PLAYERS
 * BUG FIXING
 * IMPORTING TO UNITY AND TRY TO MAKE IT 3D(?) 
 * OTHERS
*/

using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Yahtzee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //PUBLIC ARRAY FOR DICES
        public int[] playingDiceArr = new int[5] {0,0,0,0,0};

        //BUTTON THAT ROLLS THE DICES
        private void Btn_rollDice_Click(object sender, EventArgs e)
        {
            Rng generator = new Rng();
            CheckBox[] playerPick = { chk_holdD1, chk_holdD2, chk_holdD3, chk_holdD4, chk_holdD5 };
            PictureBox[] playingDicePictures = { pic_roll1 , pic_roll2, pic_roll3, pic_roll4, pic_roll5};
            Image[] images = { Properties.Resources.d1, Properties.Resources.d2, Properties.Resources.d3, Properties.Resources.d4, Properties.Resources.d5, Properties.Resources.d6 };

            int i = 0; //iterator

            //rng to get the dices a new value if the user hadn't locked any
            foreach (CheckBox box in playerPick)
            {
                if(box.Checked != true) {
                    playingDiceArr[i] = generator.DiceRng(); 
                }
                i++;
            }

            //loop to change the dice picture box to the img dice corresponding to the value that was given by the rng

            int k = 0; //iterator 
            foreach (int dice in playingDiceArr)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (dice.Equals(j))  {  playingDicePictures[k].Image = images[j - 1]; }
                }
                k++;
            }
           
            higherScoreChecker();
            lowerScoreChecker();
            TotalScoreFinals();
        }
      
        //checks the dice value with the respective score part (aces, twos etc...)
        public int SimpleDices(int checker)
        {
            int counter = 0;

            foreach(int dice in playingDiceArr)
            {
                if(dice == checker) { counter++; }
            }

            return counter;
        }

        //verifies the number of dices from Aces to Sixes score and multiplies it by the respective number if more than one dice
        //if the background is yellow, stops the verification, which means the dice was locked by the player
        public void higherScoreChecker()
        {
            Label[] diceValues = { lbl_aces, lbl_twos, lbl_threes, lbl_fours, lbl_fives, lbl_sixes };
            int i = 1;

            foreach(Label diceScore in diceValues)
            {
                if(diceScore.BackColor != Color.Yellow) { diceScore.Text = Convert.ToString(SimpleDices(i) * i); }
                i++;
            }
        }

        //method that verifies the bottom part
        //trios, four of a kind, sequences, fh, yahtzee, chances
        public void lowerScoreChecker()
        {
            //calls the method that counts the number of dices corresponding to searched dice
            //diceCount[0] gets the total of number 1 dices, diceCount[1] the number of dices number 2 , etc...
            int[] diceCount = { SimpleDices(1), SimpleDices(2), SimpleDices(3), SimpleDices(4), SimpleDices(5), SimpleDices(6) };

            //gets the value of the actual rolled dices in the board
            //these values are used to sum their value to the respective category that is picked by the user
            //EX: three of a kind was picked? sum all dices value
            int dice1_val = playingDiceArr[0];
            int dice2_val = playingDiceArr[1];
            int dice3_val = playingDiceArr[2];
            int dice4_val = playingDiceArr[3];
            int dice5_val = playingDiceArr[4];

            //======== Booleans to block the label score =========
            bool chanceBool = false;
            bool threeKindBool = false;
            bool fourKindBool = false;
            bool fullHouseBool = false;
            bool lowStraightBool = false;
            bool highStraightBool = false;
            bool yahtzeeBool = false;
            

            //========= verifies if the player has locked the label with the respective score =======
            if (lbl_score3Kind.BackColor == Color.Yellow) { threeKindBool = true; }
            if (lbl_4KindScore.BackColor == Color.Yellow) { fourKindBool = true; }
            if (lbl_scoreFH.BackColor == Color.Yellow) { fullHouseBool = true; }
            if (lbl_scoreLStraight.BackColor == Color.Yellow) { lowStraightBool = true; }
            if (lbl_scoreHStraight.BackColor == Color.Yellow) { highStraightBool = true; }
            if (lbl_scoreYat.BackColor == Color.Yellow) { yahtzeeBool = true; }
            if(lbl_scoreChance.BackColor == Color.Yellow) { chanceBool = true;  }

            //================= chance =================
            if (!chanceBool)
            {
                lbl_scoreChance.Text = Convert.ToString(diceCount[0] + (diceCount[1] * 2) + (diceCount[2] * 3) + (diceCount[3] * 4) + (diceCount[4] * 5) + (diceCount[5] * 6));
            }            

            //================= three of a kind =================
            if (!threeKindBool)
            {
                if (diceCount[0] >= 3 || diceCount[1] >= 3 || diceCount[2] >= 3 || diceCount[3] >= 3 || diceCount[4] >= 3 || diceCount[5] >= 3)
                {
                    lbl_score3Kind.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
                }
                else { lbl_score3Kind.Text = "0"; }
            }

            //================= four of a kind =================
            if (!fourKindBool)
            {                
                if (diceCount[0] >= 4 || diceCount[1] >= 4 || diceCount[2] >= 4 || diceCount[3] >= 4 || diceCount[4] >= 4 || diceCount[5] >= 4)
                {
                    lbl_4KindScore.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
                }
                else { lbl_4KindScore.Text = "0"; }
            }

            //============full house =================
            if (!fullHouseBool)
            {
                if ((diceCount[0] == 3 || diceCount[1] == 3 || diceCount[2] == 3 || diceCount[3] == 3 || diceCount[4] == 3 || diceCount[5] == 3) &&
                (diceCount[0] == 2 || diceCount[1] == 2 || diceCount[2] == 2 || diceCount[3] == 2 || diceCount[4] == 2 || diceCount[5] == 2))
                {
                    lbl_scoreFH.Text = "25";
                }
                else { lbl_scoreFH.Text = "0";}

            }

            //================= lower straights =================
            if (!lowStraightBool)
            {
                if ((dice1_val == 1 && dice2_val == 2 && dice3_val == 3 && dice4_val == 4) || (dice1_val == 2 && dice2_val == 3 && dice3_val == 4 && dice4_val == 5) ||
                   (dice1_val == 3 && dice2_val == 4 && dice3_val == 5 && dice4_val == 6) || (dice2_val == 1 && dice3_val == 2 && dice4_val == 3 && dice5_val == 4) ||
                      (dice2_val == 2 && dice3_val == 3 && dice4_val == 4 && dice5_val == 5) || (dice2_val == 3 && dice3_val == 4 && dice4_val == 5 && dice5_val == 6))
                {
                    lbl_scoreLStraight.Text = "30";
                }
                else { lbl_scoreLStraight.Text = "0"; }
            }

            //================= large straight =================
            if (!highStraightBool)
            {
                if ((dice1_val == 1 && dice2_val == 2 && dice3_val == 3 && dice4_val == 4 && dice5_val == 5) ||
                                    dice1_val == 2 && dice2_val == 3 && dice3_val == 4 && dice4_val == 5 && dice5_val == 6)
                {
                    lbl_scoreHStraight.Text = "40";
                }
                else { lbl_scoreHStraight.Text = "0"; }
            }

            //================= yahtzee =================
            if(!yahtzeeBool)
            {
                if (diceCount[0] == 5 || diceCount[1] == 5 || diceCount[2] == 5 || diceCount[3] == 5 || diceCount[4] == 5 || diceCount[5] == 5)
                {
                    lbl_scoreYat.Text = "50";
                }
                else { lbl_scoreYat.Text = "0"; }
            }
           
        }

        // ================= SCORES =======================
        public void TotalScoreFinals()
        {
            //======== int conversions for final score ======== 
            int acesScore = Convert.ToInt32(lbl_aces.Text);
            int twosScore = Convert.ToInt32(lbl_twos.Text);
            int threeScore = Convert.ToInt32(lbl_threes.Text);
            int fourScore = Convert.ToInt32(lbl_fours.Text);
            int fiveScore = Convert.ToInt32(lbl_fives.Text);
            int sixesScore = Convert.ToInt32(lbl_sixes.Text);

            // ======= BONUS =======
            if (acesScore + twosScore + threeScore + fourScore + fiveScore + sixesScore >= 63)
            {
                lbl_scoreBonus.Text = "35";
            }
            
            int bonus = Convert.ToInt32(lbl_scoreBonus.Text);
            int threeKind = Convert.ToInt32(lbl_score3Kind.Text);
            int fourKind = Convert.ToInt32(lbl_4KindScore.Text);
            int low_straight = Convert.ToInt32(lbl_scoreLStraight.Text);
            int high_straight = Convert.ToInt32(lbl_scoreHStraight.Text);
            int chance = Convert.ToInt32(lbl_scoreChance.Text);
            int yahtzee_score = Convert.ToInt32(lbl_scoreYat.Text);

            //========  total score ======== 
            int grandTotal = acesScore + twosScore + threeScore + fourScore + fiveScore + sixesScore + bonus + threeKind + fourKind
                           + low_straight + high_straight + chance + yahtzee_score;

            //========  final score  ========  
            lbl_finalScore.Text = Convert.ToString(grandTotal);
        }

        // ----------------- LABEL CLICK EVENTS -----------------
      
        public void label_click_aces(object sender, EventArgs e)
        {
            Label click_aces = sender as Label;

            if(click_aces.Enabled) { click_aces.Enabled = false;  }

            if(!click_aces.Enabled) { lbl_aces.BackColor = Color.Yellow; }
            
        }
        private void label_click_deuces(object sender, EventArgs e)
        {
            Label click_deuces = sender as Label;

            if (click_deuces.Enabled)  { click_deuces.Enabled = false;  }

            if (!click_deuces.Enabled) { click_deuces.BackColor = Color.Yellow;  }
        }

        private void label_click_threes(object sender, EventArgs e)
        {
            Label click_three = sender as Label;
           
            if (click_three.Enabled) { click_three.Enabled = false; }

            if (!click_three.Enabled) { click_three.BackColor = Color.Yellow;  }
        }

        private void label_click_fours(object sender, EventArgs e)
        {
            Label click_fours = sender as Label;

            if (click_fours.Enabled)  { click_fours.Enabled = false;  }

            if (!click_fours.Enabled) { click_fours.BackColor = Color.Yellow; }
        }

        private void label_click_fives(object sender, EventArgs e)
        {
            Label click_fives = sender as Label;

            if (click_fives.Enabled) { click_fives.Enabled = false; }

            if (!click_fives.Enabled)  { click_fives.BackColor = Color.Yellow; }
        }

        private void label_click_sixes(object sender, EventArgs e)
        {
            Label click_sixes = sender as Label;

            if (click_sixes.Enabled) { click_sixes.Enabled = false; }

            if (!click_sixes.Enabled) { click_sixes.BackColor = Color.Yellow; }
        }

        private void label_click_3Kind(object sender, EventArgs e)
        {
            Label click_3kind = sender as Label;

            if (click_3kind.Enabled) { click_3kind.Enabled = false;  }
            if (!click_3kind.Enabled) { click_3kind.BackColor = Color.Yellow; }
        }

        private void label_click_4Kind(object sender, EventArgs e)
        {
            Label click_4way = sender as Label;

            if (click_4way.Enabled) { click_4way.Enabled = false; }
            if (!click_4way.Enabled) { click_4way.BackColor = Color.Yellow; }
        }

        private void label_click_FH(object sender, EventArgs e)
        {
            Label click_fh = sender as Label;

            if (click_fh.Enabled) { click_fh.Enabled = false; }
            if (!click_fh.Enabled) { click_fh.BackColor = Color.Yellow; }
        }

        private void label_click_LS(object sender, EventArgs e)
        {
            Label click_ls = sender as Label;

            if (click_ls.Enabled) { click_ls.Enabled = false; }
            if (!click_ls.Enabled) { click_ls.BackColor = Color.Yellow; }
        }

        private void label_click_HS(object sender, EventArgs e)
        {
            Label click_hs = sender as Label;

            if (click_hs.Enabled) { click_hs.Enabled = false; }
            if (!click_hs.Enabled) { click_hs.BackColor = Color.Yellow; }
        }

        private void label_click_chance(object sender, EventArgs e)
        {
            Label click_chance = sender as Label;

            if (click_chance.Enabled) { click_chance.Enabled = false; }
            if (!click_chance.Enabled) { click_chance.BackColor = Color.Yellow; }
        }

        private void label_click_yahtzee(object sender, EventArgs e)
        {
            Label click_yahtzee = sender as Label;
           
            if (click_yahtzee.Enabled) { click_yahtzee.Enabled = false; }
            if (!click_yahtzee.Enabled) { click_yahtzee.BackColor = Color.Yellow; }
        }
    }
}

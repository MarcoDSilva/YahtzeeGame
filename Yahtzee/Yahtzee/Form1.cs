//Yahtzee Game
//made by MarcoSilva
//started at 7 july 2019

/*TODO LIST:
 * SEPARATE LOWER SCORE IN TINY METHODS INSTEAD OF ALL BEING INSIDE THE SAME METHOD - working on it
 * PUTTING THE DICE SCORES IN ARRAY FOR EASY ACCESS IN THE METHODS - working on it
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
            Label[] playingDices = { lbl_displayDice1, lbl_displayDice2, lbl_displayDice3, lbl_displayDice4, lbl_displayDice5 };

            int i = 0; //iterator for loop

            //passes the dice rng to the respective labels
            foreach (CheckBox box in playerPick)
            {
                if(box.Checked != true) {
                    playingDices[i].Text = Convert.ToString(playingDiceArr[i] = generator.DiceRng()); 
                }
                i++;
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
            //dice1 gets the total of number 1 dices, dice2 the number of dices number 2 , etc...
            int dice1 = SimpleDices(1);
            int dice2 = SimpleDices(2);
            int dice3 = SimpleDices(3);
            int dice4 = SimpleDices(4);
            int dice5 = SimpleDices(5);
            int dice6 = SimpleDices(6);

            //gets the value of the actual rolled dices in the board
            //these values are used to sum their value to the respective category that is picked by the user
            //EX: three of a kind was picked? sum all dices value
            int dice1_val = Convert.ToInt32(lbl_displayDice1.Text);
            int dice2_val = Convert.ToInt32(lbl_displayDice2.Text);
            int dice3_val = Convert.ToInt32(lbl_displayDice3.Text);
            int dice4_val = Convert.ToInt32(lbl_displayDice4.Text);
            int dice5_val = Convert.ToInt32(lbl_displayDice5.Text);

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
                lbl_scoreChance.Text = Convert.ToString(dice1 + (dice2 * 2) + (dice3 * 3) + (dice4 * 4) + (dice5 * 5) + (dice6 * 6));
            }            

            //================= three of a kind =================
            if (!threeKindBool)
            {
                if (dice1 >= 3 || dice2 >= 3 || dice3 >= 3 || dice4 >= 3 || dice5 >= 3 || dice6 >= 3)
                {
                    lbl_score3Kind.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
                }
                else { lbl_score3Kind.Text = "0"; }
            }

            //================= four of a kind =================
            if (!fourKindBool)
            {                
                if (dice1 >= 4 || dice2 >= 4 || dice3 >= 4 || dice4 >= 4 || dice5 >= 4 || dice6 >= 4)
                {
                    lbl_4KindScore.Text = Convert.ToString(dice1_val + dice2_val + dice3_val + dice4_val + dice5_val);
                }
                else { lbl_4KindScore.Text = "0"; }
            }

            //============full house =================
            if (!fullHouseBool)
            {
                if ((dice1 == 3 || dice2 == 3 || dice3 == 3 || dice4 == 3 || dice5 == 3 || dice6 == 3) &&
                (dice1 == 2 || dice2 == 2 || dice3 == 2 || dice4 == 2 || dice5 == 2 || dice6 == 2))
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
                if (dice1 == 5 || dice2 == 5 || dice3 == 5 || dice4 == 5 || dice5 == 5 || dice6 == 5)
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

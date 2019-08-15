//Yahtzee Game
//made by MarcoSilva
//started at 7 july 2019

/*TODO LIST:
 * Try to make an arrayList and separate the code in classes
 * WHEN USER LOCKS AN OPTION, MAKE THE DICE RANDOMLY GETS NEW VALUES, OR LOCK THE OPTION TO NOT LOCK MORE THAN ONE AT ONCE
 * NEW GAME BUTTON
 * ===========================
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

        //Public arrays to save the dice that is being rng'd, and to count how many of a determined dice is at the board
        public int[] playingDiceArr = new int[5] {0,0,0,0,0};
        public int rollPlayCount = 0, globalCount = -1, globalVerifier = 0;
        LowerScore bools = new LowerScore();

        //struct to contain the booleans to lock the scores from the bottom scores
        public struct LowerScore{
           public bool threeKind;
           public bool fourKind;
           public bool lowStraight;
           public bool highStraight;
           public bool chance;
           public bool fullHouse;
           public bool yahtzee;
        }

        //BUTTON THAT ROLLS THE DICES
        private void Btn_rollDice_Click(object sender, EventArgs e)
        {
            Rng generator = new Rng();
            CheckBox[] playerPick = { chk_holdD1, chk_holdD2, chk_holdD3, chk_holdD4, chk_holdD5 };
            PictureBox[] playingDicePictures = { pic_roll1 , pic_roll2, pic_roll3, pic_roll4, pic_roll5};
            Image[] images = { Properties.Resources.d1, Properties.Resources.d2, Properties.Resources.d3, Properties.Resources.d4, Properties.Resources.d5, Properties.Resources.d6 };

            EndOfGame();

            if (this.globalCount.Equals(this.globalVerifier)) {
                this.rollPlayCount = 0;
                this.globalVerifier++;
            }

            if (this.rollPlayCount < 3)  {
                int i = 0; //iterator

                //rng to get the dices a new value if the user hadn't locked any
                foreach (CheckBox box in playerPick)
                {
                    if (box.Checked != true)
                    {
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
                        if (dice.Equals(j)) { playingDicePictures[k].Image = images[j - 1]; }
                    }
                    k++;
                }

                this.rollPlayCount++;
                lbl_numberRolls.Text = rollPlayCount.ToString();
            } else {
                MessageBox.Show("Please lock a dice, you used your 3 rolls");
            }

            HigherScoreChecker();
            LowerScoreChecker();
            TotalScoreFinals();
            
        }

        public void EndOfGame()
        {
            if(this.globalCount.Equals(12))
            {
                MessageBox.Show("You finished the game! Your final score is: " + lbl_finalScore.Text);
                btn_rollDice.Enabled = false;
            }
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
        public void HigherScoreChecker()
        {
            Label[] diceValues = { lbl_aces, lbl_twos, lbl_threes, lbl_fours, lbl_fives, lbl_sixes };
            int i = 1;

            foreach(Label diceScore in diceValues)
            {
                if(diceScore.BackColor != Color.Yellow) {
                    diceScore.Text = Convert.ToString(SimpleDices(i) * i);
                }
                i++;
            }
        }

        //================= ALL METHODS HAVE A BOOLEAN TO CHECK IF THE USER LOCKED OR NOT THE OPTION ==============
        //================= IF THE OPTION ISN'T LOCKED, THEN THE SCORE CAN BE UPDATED UNTIL LOCKED ===============
        // methods for score and score!

        public void ScoreOfAKind()
        {
            int[] diceCount = { SimpleDices(1), SimpleDices(2), SimpleDices(3), SimpleDices(4), SimpleDices(5), SimpleDices(6) };
            
            this.bools.threeKind = false;
            this.bools.fourKind = false;
            
            if (lbl_score3Kind.BackColor == Color.Yellow) { this.bools.threeKind = true; }
            if (lbl_4KindScore.BackColor == Color.Yellow) { this.bools.fourKind = true; }

            //================= three of a kind =================
            if (!this.bools.threeKind)
            {
                if (diceCount[0] >= 3 || diceCount[1] >= 3 || diceCount[2] >= 3 || diceCount[3] >= 3 || diceCount[4] >= 3 || diceCount[5] >= 3)
                {
                    lbl_score3Kind.Text = Convert.ToString(playingDiceArr[0] + playingDiceArr[1] + playingDiceArr[2] + playingDiceArr[3] + playingDiceArr[4]);
                }
                else { lbl_score3Kind.Text = "0"; }
            }

            //================= four of a kind =================
            if (!this.bools.fourKind)
            {
                if (diceCount[0] >= 4 || diceCount[1] >= 4 || diceCount[2] >= 4 || diceCount[3] >= 4 || diceCount[4] >= 4 || diceCount[5] >= 4)
                {
                    lbl_4KindScore.Text = Convert.ToString(playingDiceArr[0] + playingDiceArr[1] + playingDiceArr[2] + playingDiceArr[3] + playingDiceArr[4]);
                }
                else { lbl_4KindScore.Text = "0"; }
            }
        }
       
        public void Sequences()
        {
            this.bools.lowStraight = false;
            this.bools.highStraight = false;

            if (lbl_scoreLStraight.BackColor == Color.Yellow) { this.bools.lowStraight = true; }
            if (lbl_scoreHStraight.BackColor == Color.Yellow) { this.bools.highStraight = true; }


            //================= lower straights =================
            if (!this.bools.lowStraight)
            {
                if ((playingDiceArr[0].Equals(1) && playingDiceArr[1].Equals(2) && playingDiceArr[2].Equals(3) && playingDiceArr[3].Equals(4))
                    || (playingDiceArr[0].Equals(2) && playingDiceArr[1].Equals(3) && playingDiceArr[2].Equals(4) && playingDiceArr[3].Equals(5))
                         || (playingDiceArr[0].Equals(3) && playingDiceArr[1].Equals(4) && playingDiceArr[2].Equals(5) && playingDiceArr[3].Equals(6))
                             || (playingDiceArr[1].Equals(1) && playingDiceArr[2].Equals(2) && playingDiceArr[3].Equals(3) && playingDiceArr[4].Equals(4))
                                || (playingDiceArr[1].Equals(2) && playingDiceArr[2].Equals(3) && playingDiceArr[3].Equals(4) && playingDiceArr[4].Equals(5))
                                    || (playingDiceArr[1].Equals(3) && playingDiceArr[2].Equals(4) && playingDiceArr[3].Equals(5) && playingDiceArr[4].Equals(6)))
                {
                    lbl_scoreLStraight.Text = "30";
                }
                else { lbl_scoreLStraight.Text = "0"; }
            }

            //================= large straight =================
            if (!this.bools.highStraight)
            {
                if ((playingDiceArr[0].Equals(1) && playingDiceArr[1].Equals(2) && playingDiceArr[2].Equals(3) && playingDiceArr[3].Equals(4) && playingDiceArr[4].Equals(5))
                     || playingDiceArr[0].Equals(2) && playingDiceArr[1].Equals(3) && playingDiceArr[2].Equals(4) && playingDiceArr[3].Equals(5) && playingDiceArr[4].Equals(6))
                {
                    lbl_scoreHStraight.Text = "40";
                }
                else { lbl_scoreHStraight.Text = "0"; }
            }
        }

        public void Chance()
        {
            this.bools.chance = false;

            if (lbl_scoreChance.BackColor == Color.Yellow) { this.bools.chance = true; }            

            if (!this.bools.chance)
            {
                lbl_scoreChance.Text = Convert.ToString(SimpleDices(1) + (SimpleDices(2) * 2) + (SimpleDices(3) * 3) + (SimpleDices(4) * 4) + (SimpleDices(5) * 5) + (SimpleDices(6) * 6));
            }
        }

        public void FullHouse()
        {
            this.bools.fullHouse = false;
            if (lbl_scoreFH.BackColor == Color.Yellow) { this.bools.fullHouse = true; }

            if (!this.bools.fullHouse)
            {
                if ((SimpleDices(1).Equals(3) || SimpleDices(2).Equals(3) || SimpleDices(3).Equals(3) || SimpleDices(4).Equals(3) || SimpleDices(5).Equals(3) || SimpleDices(6).Equals(3))
                    && (SimpleDices(1).Equals(2) || SimpleDices(2).Equals(2) || SimpleDices(3).Equals(2) || SimpleDices(4).Equals(2) || SimpleDices(5).Equals(2) || SimpleDices(6).Equals(2)))
                {
                    lbl_scoreFH.Text = "25";
                }
                else { lbl_scoreFH.Text = "0"; }
            }
        }

        public void Yahtzee()
        {
            this.bools.yahtzee = false;
            
            if (lbl_scoreYat.BackColor == Color.Yellow) { this.bools.yahtzee = true; }
            int[] diceCount = { SimpleDices(1), SimpleDices(2), SimpleDices(3), SimpleDices(4), SimpleDices(5), SimpleDices(6) };

            //================= yahtzee =================
            if (!this.bools.yahtzee)
            {
                foreach (int dice in diceCount)
                {
                    if (dice.Equals(5))
                    {
                        lbl_scoreYat.Text = "50";
                        break;
                    }
                    else { lbl_scoreYat.Text = "0"; }
                }
            }
        }

        public void LowerScoreChecker()
        {
            Sequences();
            FullHouse();
            ScoreOfAKind();
            Chance();
            Yahtzee();
        }

        public void TotalScoreFinals()
        {
            Label[] upperScore = { lbl_aces, lbl_twos, lbl_threes, lbl_fours, lbl_fives, lbl_sixes };
            Label[] bottomScore = { lbl_scoreBonus , lbl_score3Kind, lbl_4KindScore, lbl_scoreLStraight, lbl_scoreHStraight, lbl_scoreChance, lbl_scoreYat };

            // ======= DEFINING BONUS =======
            int sumUpperScore = 0;
            foreach(Label upper in upperScore)
            {
                sumUpperScore += Convert.ToInt32(upper.Text);
            }
           
            // if uppersum is higher than 63, player gets 35 extra bonus as the rules state
            if (sumUpperScore >= 63)
            {
                lbl_scoreBonus.Text = "35";
            }

            // ======= BOTTOM SUM ======
            int sumBottomScore = 0;
            foreach(Label bottom in bottomScore)
            {
                sumBottomScore += Convert.ToInt32(bottom.Text);
            }

            //========  total score ======== 
            int grandTotal = sumUpperScore + sumBottomScore;
            lbl_finalScore.Text = Convert.ToString(grandTotal);
        }

        // ----------------- LABEL CLICK EVENTS -----------------
        public void label_click_aces(object sender, EventArgs e) {
            Label click_aces = sender as Label;

            if(click_aces.Enabled) { click_aces.Enabled = false;  }
            if(!click_aces.Enabled) { lbl_aces.BackColor = Color.Yellow; this.globalCount++; }            
        }
        private void label_click_deuces(object sender, EventArgs e){
            Label click_deuces = sender as Label;

            if (click_deuces.Enabled)  { click_deuces.Enabled = false;  }
            if (!click_deuces.Enabled) { click_deuces.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_threes(object sender, EventArgs e){
            Label click_three = sender as Label;
           
            if (click_three.Enabled) { click_three.Enabled = false; }
            if (!click_three.Enabled) { click_three.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_fours(object sender, EventArgs e) {
            Label click_fours = sender as Label;

            if (click_fours.Enabled)  { click_fours.Enabled = false; }
            if (!click_fours.Enabled) { click_fours.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_fives(object sender, EventArgs e) { 
            Label click_fives = sender as Label;

            if (click_fives.Enabled) { click_fives.Enabled = false; }
            if (!click_fives.Enabled)  { click_fives.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_sixes(object sender, EventArgs e) {
            Label click_sixes = sender as Label;

            if (click_sixes.Enabled) { click_sixes.Enabled = false; }
            if (!click_sixes.Enabled) { click_sixes.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_3Kind(object sender, EventArgs e) {
            Label click_3kind = sender as Label;

            if (click_3kind.Enabled) { click_3kind.Enabled = false; }
            if (!click_3kind.Enabled) { click_3kind.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_4Kind(object sender, EventArgs e) {
            Label click_4way = sender as Label;

            if (click_4way.Enabled) { click_4way.Enabled = false; }
            if (!click_4way.Enabled) { click_4way.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_FH(object sender, EventArgs e) {
            Label click_fh = sender as Label;

            if (click_fh.Enabled) { click_fh.Enabled = false; }
            if (!click_fh.Enabled) { click_fh.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_LS(object sender, EventArgs e) {
            Label click_ls = sender as Label;

            if (click_ls.Enabled) { click_ls.Enabled = false; }
            if (!click_ls.Enabled) { click_ls.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_HS(object sender, EventArgs e) {
            Label click_hs = sender as Label;

            if (click_hs.Enabled) { click_hs.Enabled = false; }
            if (!click_hs.Enabled) { click_hs.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_chance(object sender, EventArgs e) {
            Label click_chance = sender as Label;

            if (click_chance.Enabled) { click_chance.Enabled = false; }
            if (!click_chance.Enabled) { click_chance.BackColor = Color.Yellow; this.globalCount++; }
        }

        private void label_click_yahtzee(object sender, EventArgs e) {
            Label click_yahtzee = sender as Label;
           
            if (click_yahtzee.Enabled) { click_yahtzee.Enabled = false; }
            if (!click_yahtzee.Enabled) { click_yahtzee.BackColor = Color.Yellow; this.globalCount++; }
        }
    }
}

//Yahtzee Game
//made by MarcoSilva
//started at 7 july 2019

/*TODO LIST:
 * ADD A BUTTON WITH THE RULES
 * DESIGN MISC - BUTTONS AND MENU STRIP
 * POTENCIAL CODE REFACTOR IN SOME METHODS(?)
 * BOT PLAYER || 2 PLAYERS
 * BUG FIXING - sometimes locking more than one option in a row gets the game stuck in the counter of 3
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
 
        //BUTTON THAT ROLLS THE DICES
        private void Btn_rollDice_Click(object sender, EventArgs e)
        {           
            CheckBox[] playerPick = { chk_holdD1, chk_holdD2, chk_holdD3, chk_holdD4, chk_holdD5 };
            PictureBox[] playingDicePictures = { pic_roll1 , pic_roll2, pic_roll3, pic_roll4, pic_roll5};
            Image[] images = { Properties.Resources.d1, Properties.Resources.d2, Properties.Resources.d3, Properties.Resources.d4, Properties.Resources.d5, Properties.Resources.d6 };

            GameEndVerifier();
            GameCounterReset(playerPick);
            GameLogic(playerPick, playingDicePictures, images);
            Scores();           
        }

        //game logic that changes the dices, images, and verifies the number of plays
        public void GameLogic(CheckBox[] box, PictureBox[] pics, Image[] images)
        {
            GameManagement gameOptions = new GameManagement();
            if (this.rollPlayCount < 3)
            {

                gameOptions.GenerateDices(box, playingDiceArr);
                gameOptions.ChangeDicePicture(playingDiceArr, pics, images);

                this.rollPlayCount++;
                lbl_numberRolls.Text = rollPlayCount.ToString();
            }
            else
            {
                MessageBox.Show("Please lock a dice, you used your 3 rolls");
            }
        }

        //resets the play counter and the checkboxes when the player selects one option to lock
        public void GameCounterReset(CheckBox[] boxes)
        {
            if (this.globalCount.Equals(this.globalVerifier))
            {
                this.rollPlayCount = 0;
                this.globalVerifier++;

                foreach (CheckBox player in boxes)
                {
                    player.Checked = false;
                }
            }
        }

        //terminates the game when all plays are completed
        public void GameEndVerifier()
        {
            if (this.globalCount.Equals(12))
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

        //method that calls the methods that update the scores
        public void Scores()
        {
            HigherScoreChecker();
            LowerScoreChecker();
            TotalScoreFinals();
        }

        //verifies the number of dices from Aces to Sixes score and multiplies it by the respective number if more than one dice
        //if the background is yellow, stops the verification, which means the dice was locked by the player
        public void HigherScoreChecker()
        {
            Label[] diceValues = { lbl_aces, lbl_twos, lbl_threes, lbl_fours, lbl_fives, lbl_sixes };

            int i = 1;

            foreach (Label diceScore in diceValues)  {
                if (diceScore.BackColor != Color.Yellow) {
                    diceScore.Text = Convert.ToString(SimpleDices(i) * i);
                }
                i++;
            }
        }

        public void LowerScoreChecker()
        {
            int[] diceCount = { SimpleDices(1), SimpleDices(2), SimpleDices(3), SimpleDices(4), SimpleDices(5), SimpleDices(6) };

            GameManagement gameManagement = new GameManagement();

            gameManagement.ThreeOfAKind(diceCount, lbl_score3Kind, playingDiceArr);
            gameManagement.FourOfAKind(diceCount, lbl_4KindScore, playingDiceArr);
            gameManagement.FullHouse(lbl_scoreFH, diceCount);
            gameManagement.LowStraight(lbl_scoreLStraight, playingDiceArr);
            gameManagement.HighStraight(lbl_scoreHStraight, playingDiceArr);
            gameManagement.Chance(lbl_scoreChance, diceCount);
            gameManagement.Yahtzee(lbl_scoreYat, diceCount);
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

        //RESET BUTTON
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox[] playerPick = { chk_holdD1, chk_holdD2, chk_holdD3, chk_holdD4, chk_holdD5 };
            Label[] upperScore = { lbl_aces, lbl_twos, lbl_threes, lbl_fours, lbl_fives, lbl_sixes };
            Label[] bottomScore = { lbl_scoreBonus, lbl_score3Kind, lbl_4KindScore, lbl_scoreLStraight, lbl_scoreHStraight, lbl_scoreChance, lbl_scoreYat, lbl_finalScore };

            //resets the counter and dices variables
            this.playingDiceArr = new int[5] { 0, 0, 0, 0, 0 };
            this.rollPlayCount = 0;
            this.globalCount = -1;
            this.globalVerifier = 0;

            foreach(CheckBox player in playerPick){
                player.Checked = false;
            }

            foreach(Label upper in upperScore){
                upper.Text = "0";
                upper.BackColor = Color.Transparent;
                upper.Enabled = true;
            }

            foreach (Label bottom in bottomScore)
            {
                bottom.Text = "0";
                bottom.BackColor = Color.Transparent;
                bottom.Enabled = true;
            }

            MessageBox.Show("Game Reseted! Good luck!");
        }

        //ABOUT BUTTON
        private void AboutGameStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Marco Silva.\nBeta Version 1.0.0");
        }

        //----------------- LABEL CLICK EVENTS -----------------
        public void label_click_aces(object sender, EventArgs e)
        {
            Label click_aces = sender as Label;

            if (click_aces.Enabled) { click_aces.Enabled = false; }
            if (!click_aces.Enabled) { lbl_aces.BackColor = Color.Yellow; this.globalCount++; }
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

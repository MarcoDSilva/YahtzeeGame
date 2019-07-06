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

        //scor
        private void ScoreBox_Enter(object sender, EventArgs e)
        {

        }

        private void LayoutPanel_dices_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_rollDice_Click(object sender, EventArgs e)
        {
            Rng generator = new Rng();
            lbl_displayDice1.Text = Convert.ToString(generator.DiceRng());
            lbl_displayDice2.Text = Convert.ToString(generator.DiceRng());
            lbl_displayDice3.Text = Convert.ToString(generator.DiceRng());
            lbl_displayDice4.Text = Convert.ToString(generator.DiceRng());
            lbl_displayDice5.Text = Convert.ToString(generator.DiceRng());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Yahtzee
{
    class GameManagement
    {
        Rng generator = new Rng();

        //Random generates the dice values
        //there may be a fix to do, seems sometimes it repeats 2 dices a lot
        public void GenerateDices(CheckBox[] boxes, int[] list)
        {
            int i = 0; //iterator

            foreach (CheckBox box in boxes)
            {
                if (box.Checked != true) {
                    list[i] = generator.DiceRng();
                }
                i++;
            }
        }

        //change the dice pictures of the rolling dices
        public void ChangeDicePicture(int[] list, PictureBox[] pictures, Image[] images)
        {
            int k = 0; //iterator 
            foreach (int dice in list)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (dice.Equals(j)) { pictures[k].Image = images[j - 1]; }
                }
                k++;
            }
        }

        public void ThreeOfAKind(int[] list, Label label, int[] dices)
        {
            if (!LockVerifier(label)) {
                if (list[0] >= 3 || list[1] >= 3 || list[2] >= 3 || list[3] >= 3 || list[4] >= 3 || list[5] >= 3)
                {
                    label.Text = Convert.ToString(dices[0] + dices[1] + dices[2] + dices[3] + dices[4]);
                }
                else { label.Text = "0"; }
            }
        }

        public void FourOfAKind(int[] list, Label label, int[] dices)
        {
            if (!LockVerifier(label)) {
                if (list[0] >= 4 || list[1] >= 4 || list[2] >= 4 || list[3] >= 4 || list[4] >= 4 || list[5] >= 4)
                {
                    label.Text = Convert.ToString(dices[0] + dices[1] + dices[2] + dices[3] + dices[4]);
                }
                else { label.Text = "0"; }
            }
        }

        public void LowStraight(Label label, int[] list)
        {            
            if (!LockVerifier(label)) {
                if (list.Contains(1) && list.Contains(2) && list.Contains(3) && list.Contains(4)
                        || list.Contains(2) && list.Contains(3) && list.Contains(4) && list.Contains(5)
                            || list.Contains(3) && list.Contains(4) && list.Contains(5) && list.Contains(6))
                {
                    label.Text = "30";
                }
                else { label.Text = "0"; }
            }
        }

        public void HighStraight(Label label, int[] list)
        {
            if (!LockVerifier(label)) {
                if ((list.Contains(1) && list.Contains(2) && list.Contains(3) && list.Contains(4) && list.Contains(5))
                     || list.Contains(2) && list.Contains(3) && list.Contains(4) && list.Contains(5) && list.Contains(6))
                {
                    label.Text = "40";
                }
                else { label.Text = "0"; }
            }
        }

        public void Chance(Label label, int[] list)
        {
            if (!LockVerifier(label)) {
               label.Text = Convert.ToString(list[0] + (list[1] * 2) + (list[2] * 3) + (list[3] * 4) + (list[4] * 5) + (list[5] * 6));
            }
        }

        public void FullHouse(Label label, int[] list)
        {
            if (!LockVerifier(label))  {
                if ((list[0].Equals(3) || list[1].Equals(3) || list[2].Equals(3) || list[3].Equals(3) || list[4].Equals(3) || list[5].Equals(3))
                    && (list[0].Equals(2) || list[1].Equals(2) || list[2].Equals(2) || list[3].Equals(2) || list[4].Equals(2) || list[5].Equals(2)))
                {
                    label.Text = "25";
                }
                else { label.Text = "0"; }
            }
        }

        public void Yahtzee(Label label, int[] list)
        {
            if (!LockVerifier(label)) {
                foreach (int dice in list)
                {
                    if (dice.Equals(5)) {
                        label.Text = "50";
                        break;
                    }
                    else { label.Text = "0"; }
                }
            }
        }

        //verifies if the label was locked by the user
        private Boolean LockVerifier(Label label)
        {
            return label.BackColor == Color.Yellow;
        }
    }

}

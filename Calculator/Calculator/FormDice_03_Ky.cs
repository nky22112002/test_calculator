using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormDice_03_Ky : Form
    {
        private int dice_03_Ky;
        private int countTurn_03_Ky = 1;
        private int resultPoint1_03_Ky;
        private int resultPoint2_03_Ky;
        public FormDice_03_Ky()
        {
            InitializeComponent();
        }

        
        public void randomDice_03_Ky(PictureBox pictureBox, Random random)
        {
            int randomNumber = random.Next(1, 7);
            this.dice_03_Ky = randomNumber;
            switch (randomNumber)
            {
                case 1:
                    pictureBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources._6;
                    break;

            }
        }
        public int GetPoint_03_Ky()
        {
            return this.dice_03_Ky;
        }
        public void Points_03_Ky(Label label, int a)
        {
            label.Text = a.ToString();
        }
        

        

        

        private void btnBackDice_03_Ky_Click(object sender, EventArgs e)
        {
            Form1_03_Ky form1 = new Form1_03_Ky();
            form1.Show();
            this.Hide();
        }

        private void btnResult_03_Ky_Click(object sender, EventArgs e)
        {
            if (!(this.countTurn_03_Ky <= 6))
            {
                if (resultPoint1_03_Ky > resultPoint2_03_Ky)
                {
                    MessageBox.Show("Player 1 winner!!!");
                }
                else
                {
                    MessageBox.Show("Player 2 winner!!!");
                }

                this.countTurn_03_Ky = 0;
                this.resultPoint1_03_Ky = this.resultPoint2_03_Ky = 0;
            }
            else
            {
                MessageBox.Show("The game hasn't end yet");
            }
        }

        private void btnPlay2_03_Ky_Click(object sender, EventArgs e)
        {
            int sumPoint = 0;
            Random random = new Random();
            if (lbTurn_03_Ky.Text == "Player 1")
            {
                MessageBox.Show("It's Player 1's turn");
            }
            else if (this.countTurn_03_Ky <= 6)
            {
                randomDice_03_Ky(pBox1_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                randomDice_03_Ky(pBox2_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                randomDice_03_Ky(pBox3_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                this.resultPoint2_03_Ky += sumPoint;

                switch (this.countTurn_03_Ky)
                {
                    case 2:
                        Points_03_Ky(lbTurn4_03_Ky, sumPoint);
                        break;
                    case 4:
                        Points_03_Ky(lbTurn5_03_Ky, sumPoint);
                        break;
                    case 6:
                        Points_03_Ky(lbTurn6_03_Ky, sumPoint);
                        break;
                    default:
                        break;
                }
                this.countTurn_03_Ky++;
            }
            lbTurn_03_Ky.Text = "Player 1";
        }

        private void btnPlay1_03_Ky_Click(object sender, EventArgs e)
        {
            int sumPoint = 0;
            Random random = new Random();
            if (lbTurn_03_Ky.Text == "Player 2")
            {
                MessageBox.Show("It's Player 2's turn");
            }
            else if (this.countTurn_03_Ky <= 5)
            {
                randomDice_03_Ky(pBox1_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                randomDice_03_Ky(pBox2_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                randomDice_03_Ky(pBox3_03_Ky, random);
                sumPoint += GetPoint_03_Ky();
                this.resultPoint1_03_Ky += sumPoint;
                switch (this.countTurn_03_Ky)
                {
                    case 1:
                        Points_03_Ky(lbTurn1_03_Ky, sumPoint);
                        break;
                    case 3:
                        Points_03_Ky(lbTurn2_03_Ky, sumPoint);
                        break;
                    case 5:
                        Points_03_Ky(lbTurn3_03_Ky, sumPoint);
                        break;
                    default:
                        break;

                }
                this.countTurn_03_Ky++;

            }
            lbTurn_03_Ky.Text = "Player 2";
        }
    }
}

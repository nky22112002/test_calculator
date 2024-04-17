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
    public partial class FormDice : Form
    {
        private int dice;
        private int countTurn = 1;
        private int resultPoint1;
        private int resultPoint2;
        public FormDice()
        {
            InitializeComponent();
        }

        private void btnBackDice_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        public void randomDice(PictureBox pictureBox, Random random)
        {
            int randomNumber = random.Next(1, 7);
            this.dice = randomNumber;
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
        public int GetPoint()
        {
            return this.dice;
        }
        public void Points(Label label, int a)
        {
            label.Text = a.ToString();
        }
        private void btnPlay1_Click(object sender, EventArgs e)
        {
            int sumPoint = 0;
            Random random = new Random();
            if (lbTurn.Text == "Player 2")
            {
                MessageBox.Show("It's Player 2's turn");
            }
            else if(this.countTurn <= 5)
            {
                randomDice(pBox1, random);
                sumPoint += GetPoint();
                randomDice(pBox2, random);
                sumPoint += GetPoint();
                randomDice(pBox3, random);
                sumPoint += GetPoint();
                this.resultPoint1 += sumPoint;
                switch (this.countTurn)
                {
                    case 1:
                        Points(lbTurn1, sumPoint);
                        break;
                    case 3:
                        Points(lbTurn2, sumPoint);
                        break;
                    case 5:
                        Points(lbTurn3, sumPoint);
                        break;
                    default:
                        break;

                }
                this.countTurn++;

            }
            lbTurn.Text = "Player 2";
            
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            int sumPoint = 0;
            Random random = new Random();
            if (lbTurn.Text == "Player 1")
            {
                MessageBox.Show("It's Player 1's turn");
            }
            else if (this.countTurn <= 6)
            {
                randomDice(pBox1, random);
                sumPoint += GetPoint();
                randomDice(pBox2, random);
                sumPoint += GetPoint();
                randomDice(pBox3, random);
                sumPoint += GetPoint();
                this.resultPoint2 += sumPoint;

                switch (this.countTurn)
                {
                    case 2:
                        Points(lbTurn4, sumPoint);
                        break;
                    case 4:
                        Points(lbTurn5, sumPoint);
                        break;
                    case 6:
                        Points(lbTurn6, sumPoint);
                        break;
                    default:
                        break;
                }
                this.countTurn++;
            }
            lbTurn.Text = "Player 1";

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(!(this.countTurn <= 6))
            {
                if (resultPoint1 > resultPoint2)
                {
                    MessageBox.Show("Player 1 winner!!!");
                }
                else
                {
                    MessageBox.Show("Player 2 winner!!!");
                }

                this.countTurn = 0;
                this.resultPoint1 = this.resultPoint2 = 0;
            }
            else
            {
                MessageBox.Show("The game hasn't end yet");
            }
            
        }
    }
}

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
    public partial class FormKeoBuaBao_03_Ky : Form
    {
        string message = "";
        public string GetMessage() { return this.message; }
        public FormKeoBuaBao_03_Ky()
        {
            InitializeComponent();
            
        }
        private void btnBackGame123_Click(object sender, EventArgs e)
        {
            Form1_03_Ky form1 = new Form1_03_Ky();
            form1.Show();
            this.Hide();
        }

        private void btnKeo_03_Ky_Click(object sender, EventArgs e)
        {
            if (lbTurn_03_Ky.Text == "Player 1")
            {
                lbPlayer1_03_Ky.Text = "Scissors";
            }
            else
            {
                lbPlayer2_03_Ky.Text = "Scissors";
            }
            lbTurn_03_Ky.Text = "Player 2";
        }

        private void btnBua_03_Ky_Click(object sender, EventArgs e)
        {
            if (lbTurn_03_Ky.Text == "Player 1")
            {
                lbPlayer1_03_Ky.Text = "Rock";
            }
            else
            {
                lbPlayer2_03_Ky.Text = "Rock";
            }
            lbTurn_03_Ky.Text = "Player 2";
        }

        private void btnBao_03_Ky_Click(object sender, EventArgs e)
        {
            if (lbTurn_03_Ky.Text == "Player 1")
            {
                lbPlayer1_03_Ky.Text = "Paper";
            }
            else
            {
                lbPlayer2_03_Ky.Text = "Paper";
            }
            lbTurn_03_Ky.Text = "Player 2";
        }

        private void btnResult_03_Ky_Click(object sender, EventArgs e)
        {
            if (lbPlayer1_03_Ky.Text == "") MessageBox.Show("Please choose a card");
            else if (lbPlayer2_03_Ky.Text == "") MessageBox.Show("Player 2 hasn't chosen yet!!!");
            else
            {
                GameKeoBuaBao_03_Ky gameKeoBuaBao = new GameKeoBuaBao_03_Ky(lbPlayer1_03_Ky.Text, lbPlayer2_03_Ky.Text);
                gameKeoBuaBao.HandleKeoBuaBao_03_Ky();
                lbTurn_03_Ky.Text = "Player 1";
                lbPlayer1_03_Ky.Text = "";
                lbPlayer2_03_Ky.Text = "";
            }
        }
    }
}

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
    public partial class Form2 : Form
    {
        string message = "";
        public string GetMessage() { return this.message; }
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void btnKeo_Click(object sender, EventArgs e)
        {
            if (lbTurn.Text == "Player 1")
            {
                lbPlayer1.Text = "Scissors";
            }
            else
            {
                lbPlayer2.Text = "Scissors";
            }
            lbTurn.Text = "Player 2";
        }

        private void btnBua_Click(object sender, EventArgs e)
        {
            if (lbTurn.Text == "Player 1")
            {
                lbPlayer1.Text = "Rock";
            }
            else
            {
                lbPlayer2.Text = "Rock";
            }
            lbTurn.Text = "Player 2";
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            if (lbTurn.Text == "Player 1")
            {
                lbPlayer1.Text = "Paper";
            }
            else
            {
                lbPlayer2.Text = "Paper";
            }
            lbTurn.Text = "Player 2";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (lbPlayer1.Text == "") MessageBox.Show("Please choose a card");
            else if (lbPlayer2.Text == "")  MessageBox.Show("Player 2 hasn't chosen yet!!!");
            else
            {
                GameKeoBuaBao gameKeoBuaBao = new GameKeoBuaBao(lbPlayer1.Text, lbPlayer2.Text);
                gameKeoBuaBao.HandleKeoBuaBao();
                lbTurn.Text = "Player 1";
                lbPlayer1.Text = "";
                lbPlayer2.Text = "";
            }
            
        }

        private void btnBackGame123_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

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
    public partial class Form1_03_Ky : Form
    {
        public Form1_03_Ky()
        {
            InitializeComponent();
        }

        private void btnGame123_03_Ky_Click(object sender, EventArgs e)
        {
            FormKeoBuaBao_03_Ky form2 = new FormKeoBuaBao_03_Ky();
            form2.Show();
            this.Hide();
        }

        private void btnDice_03_Ky_Click(object sender, EventArgs e)
        {
            FormDice_03_Ky dice = new FormDice_03_Ky();
            dice.Show();
            this.Hide();
        }
    }
}

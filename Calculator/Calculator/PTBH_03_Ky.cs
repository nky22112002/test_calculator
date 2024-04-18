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
    public partial class PTBH_03_Ky : Form
    {
        public PTBH_03_Ky()
        {
            InitializeComponent();
        }

        private void btnKQ_03_Ky_Click(object sender, EventArgs e)
        {
            GiaiPTBH_03_Ky giaiPTBH_03_Ky = new GiaiPTBH_03_Ky();
            int a, b, c;
            int checkFormat = giaiPTBH_03_Ky.checkFormatLabel(tBoxA_03_Ky, tBoxB_03_Ky, tBoxC_03_Ky);

            if (checkFormat == 0)
            {
                a = int.Parse(tBoxA_03_Ky.Text);
                b = int.Parse(tBoxB_03_Ky.Text);
                c = int.Parse(tBoxC_03_Ky.Text);
                lbResult.Text = giaiPTBH_03_Ky.HandleButtonKQ_03_Ky(a, b, c);
            }
            else if (checkFormat == 1)
            {
                MessageBox.Show(giaiPTBH_03_Ky.GetMessage());

            }
            else
            {
                MessageBox.Show(giaiPTBH_03_Ky.GetMessage());
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class GameKeoBuaBao_03_Ky
    {
        private string message_03_Ky, a_03_Ky, b_03_Ky;
        public GameKeoBuaBao_03_Ky(string a_03_Ky, string b_03_Ky) { 
            this.a_03_Ky = a_03_Ky;
            this.b_03_Ky = b_03_Ky;
        }
        public string GetMessage()
        {
            return this.message_03_Ky;
        }
        public void HandleKeoBuaBao_03_Ky()
        {
            int c_03_Ky, d_03_Ky;
            if (this.a_03_Ky == "Rock") c_03_Ky = 1;
            else if (this.a_03_Ky == "Paper") c_03_Ky = 2;
            else c_03_Ky = 3;
            if (this.b_03_Ky == "Rock") d_03_Ky = 1;
            else if (this.b_03_Ky == "Paper") d_03_Ky = 2;
            else d_03_Ky = 3;
            switch (c_03_Ky ^ d_03_Ky)
            {
                case 0:
                    this.message_03_Ky = "Draw!!!";
                    break;
                case 1:
                    if (this.a_03_Ky == "Scissors")
                    {
                        this.message_03_Ky = "Player 1 win!!!";
                    }
                    else
                    {
                        this.message_03_Ky = "Player 2 win!!!";
                    }
                    break;
                case 2:
                    if (this.a_03_Ky == "Rock")
                    {
                        this.message_03_Ky = "Player 1 win!!!";
                    }
                    else
                    {
                        this.message_03_Ky = "Player 2 win!!!";
                    }
                    break;
                case 3:
                    if (this.a_03_Ky == "Rock")
                    {
                        this.message_03_Ky = "Player 2 win!!!";
                    }
                    else
                    {
                        this.message_03_Ky = "Player 1 win!!!";
                    }
                    break;
            }
            MessageBox.Show(this.message_03_Ky);
        }
    }
}

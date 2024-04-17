using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class GameKeoBuaBao
    {
        private string message, a, b;
        public GameKeoBuaBao(string a, string b) { 
            this.a = a;
            this.b = b;
        }
        public string GetMessage()
        {
            return this.message;
        }
        public void HandleKeoBuaBao()
        {
            int c, d;
            if (this.a == "Rock") c = 1;
            else if (this.a == "Paper") c = 2;
            else c = 3;
            if (this.b == "Rock") d = 1;
            else if (this.b == "Paper") d = 2;
            else d = 3;
            switch (c ^ d)
            {
                case 0:
                    this.message = "Draw!!!";
                    break;
                case 1:
                    if (this.a == "Scissors")
                    {
                        this.message = "Player 1 win!!!";
                    }
                    else
                    {
                        this.message = "Player 2 win!!!";
                    }
                    break;
                case 2:
                    if (this.a == "Rock")
                    {
                        this.message = "Player 1 win!!!";
                    }
                    else
                    {
                        this.message = "Player 2 win!!!";
                    }
                    break;
                case 3:
                    if (this.a == "Rock")
                    {
                        this.message = "Player 2 win!!!";
                    }
                    else
                    {
                        this.message = "Player 1 win!!!";
                    }
                    break;
            }
            MessageBox.Show(this.message);
        }
    }
}

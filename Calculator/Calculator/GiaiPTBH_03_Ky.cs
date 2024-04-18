using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public class GiaiPTBH_03_Ky
    {
        int a, b, c;
        string message = "";
        public string GetMessage()
        {
            return this.message;
        }
        
        public void HandleButtonKQ_03_Ky(double a, double b, double c, Label label)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                // Phương trình có 2 nghiệm
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                this.message = $"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}";
                label.Text = this.message;
            }
            else if (delta == 0)
            {
                // Phương trình có nghiệm kép
                double x = -b / (2 * a);
                this.message = $"Phương trình có nghiệm kép: x = {x}";
                label.Text = this.message;
            }
            else
            {
                // Phương trình không có nghiệm thực
                this.message = "Phương trình không có nghiệm thực";
                label.Text = this.message;

            }
        }
        public int checkFormatLabel(TextBox a, TextBox b, TextBox c)
        {
            if (a.Text == "" || b.Text == "" || c.Text == "")
            {
                this.message = "Vui lòng nhập đầy đủ!!!";
                return 1;
            }
            else {
                double valueA, valueB, valueC;

                if (!double.TryParse(a.Text, out valueA) || !double.TryParse(b.Text, out valueB) || !double.TryParse(c.Text, out valueC))
                {
                    this.message = "Vui lòng nhập các giá trị là số thực!!!";
                    return 2;
                }
            }
            return 0;
        }
        
    }
}

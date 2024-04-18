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
        
        public string HandleButtonKQ_03_Ky(double a, double b, double c)
        {
            double delta = b * b - (4 * a * c);
            if(a == 0)
            {
                double x = c / b;
                this.message = $"The equation has a single root: x = {x.ToString("0.###")}";
                return this.message;
            }
            else if (delta > 0)
            {
                // Phương trình có 2 nghiệm
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                this.message = $"The equation has 2 roots: x1 = {x1.ToString("0.###")} x2 = {x2.ToString("0.###")}";
                return this.message;
            }
            else if (delta == 0)
            {
                // Phương trình có nghiệm kép
                double x = -b / (2 * a);
                this.message = $"The equation has a double root: x = {x.ToString("0.###")}";
                return this.message;
            }
            else
            {
                // Phương trình không có nghiệm thực
                this.message = "The equation has no real roots";
                return this.message;

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

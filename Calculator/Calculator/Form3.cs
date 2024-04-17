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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            double[] ketQua; // Sử dụng mảng để lưu trữ cả hai nghiệm
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            PTBH pTBH = new PTBH(a, b, c);
            ketQua = pTBH.Giai(); // Lấy kết quả từ phương thức Giai
            textKQ.Text = "Nghiệm 1: " + ketQua[0].ToString() + "\r\n" + "Nghiệm 2: " + ketQua[1].ToString();
        }
    }
}

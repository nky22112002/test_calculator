using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class PTBH
    {
        private double a, b, c;
        double delta;
        public PTBH(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            TinhDelta();
        }
        private void TinhDelta()
        {
            delta = Math.Pow(b, 2) - 4 * a * c;
        }

        // Phương thức giải phương trình bậc hai
        public double[] Giai()
        {
            double[] result = new double[2]; // Khởi tạo mảng để lưu trữ giá trị của nghiệm

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phương trình có một nghiệm kép:");
                Console.WriteLine("x = " + x);
                result[0] = x; // Gán giá trị của nghiệm vào mảng result
                result[1] = x; // Gán giá trị của nghiệm vào mảng result
            }
            else // delta > 0
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có hai nghiệm phân biệt:");
                Console.WriteLine("Nghiệm 1: " + x1);
                Console.WriteLine("Nghiệm 2: " + x2);
                result[0] = x1; // Gán giá trị của nghiệm vào mảng result
                result[1] = x2; // Gán giá trị của nghiệm vào mảng result
            }

            return result; // Trả về mảng chứa giá trị của cả hai nghiệm
        }


    }





}


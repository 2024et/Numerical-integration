using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerical_integration
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void 長方形近似法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void 長方形近似法ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        
        private void label9_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(range_a.Text);
            int b = int.Parse(range_b.Text);
            int an = int.Parse(division.Text);
            int fusionA = int.Parse(textBox1.Text);
            int fusionB = int.Parse(textBox2.Text);
            int fusionC = int.Parse(textBox3.Text);
            decimal x0 = 0;
            decimal x = 0;
            decimal x1 = 0;
            decimal x2 = 0;
            decimal x3 = 0;
            decimal x4 = 0;
            decimal x5 = 0;
            decimal x6 = 0;
            decimal x7 = 0;
            decimal x8 = 0;
            decimal x9 = 0;

            int n = 2 * an;
            decimal realize_c = b - a;

            decimal realize_z = realize_c / an;
            decimal realize_d = realize_c / n;

            
            if (an == 2)
            {
                decimal n1 = a + realize_z * 1;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x = b * b * fusionA + b * fusionB + fusionC;
            }
            else if (an == 3)
            {
                decimal n1 = a + realize_z * 1;
                decimal n2 = a + realize_z * 2;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x = b * b * fusionA + b * fusionB + fusionC;

            }
            else if (an == 4)
            {
                decimal n1 = a + realize_z * 1;
                decimal n2 = a + realize_z * 2;
                decimal n3 = a + realize_z * 3;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
                x = b * b * fusionA + b * fusionB + fusionC;
            }
            else if(an == 5)
            {
                decimal n1 = a + realize_z * 1;
                decimal n2 = a + realize_z * 2;
                decimal n3 = a + realize_z * 3;
                decimal n4 = a + realize_z * 4;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
                x4 = n4 * n4 * fusionA + n4 * fusionB + fusionC;
                x = b * b * fusionA + b * fusionB + fusionC;
            }
            else if(an == 10)
            {
                decimal n1 = a + realize_z * 1;
                decimal n2 = a + realize_z * 2;
                decimal n3 = a + realize_z * 3;
                decimal n4 = a + realize_z * 4;
                decimal n5 = a + realize_z * 5;
                decimal n6 = a + realize_z * 6;
                decimal n7 = a + realize_z * 7;
                decimal n8 = a + realize_z * 8;
                decimal n9 = a + realize_z * 9;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
                x4 = n4 * n4 * fusionA + n4 * fusionB + fusionC;
                x5 = n5 * n5 * fusionA + n5 * fusionB + fusionC;
                x6 = n6 * n6 * fusionA + n6 * fusionB + fusionC;
                x7 = n7 * n7 * fusionA + n7 * fusionB + fusionC;
                x8 = n8* n8 * fusionA + n8 * fusionB + fusionC;
                x9 = n9 * n9 * fusionA + n9 * fusionB + fusionC;
                x = b * b * fusionA + b * fusionB + fusionC;
            }

            decimal k = x1 + x2 + x3 + x4 +x5 + x6 +x7 + x8 + x9;
            decimal realize_e = x0 + 2 * k +x;

            decimal realize = realize_d * realize_e;

            String realize_number1 = realize.ToString();
            //answer_label = label9.Text
            answer_label.Text = realize_number1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void 台形近似法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}

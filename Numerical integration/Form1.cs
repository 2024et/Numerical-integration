namespace Numerical_integration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void 長方形近似法ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void 台形近似法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        public void label4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(range_a.Text);
            int b = int.Parse(range_b.Text);
            int n = int.Parse(division.Text);
            int fusionA = int.Parse(textBox4.Text);
            int fusionB = int.Parse(textBox5.Text);
            int fusionC = int.Parse(textBox6.Text);
            decimal x0 = 0;
            decimal x1 = 0;
            decimal x2 = 0;
            decimal x3 = 0;
            decimal x4 = 0;
            decimal x5 = 0;
            decimal x6 = 0;
            decimal x7 = 0;
            decimal x8 = 0;
            decimal x9 = 0;
            decimal realize_c = b - a;

            decimal realize_d = realize_c / n;

            if (n == 2)
            {
                decimal n1 = a + realize_d * 1;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
            }
            else if (n == 3)
            {
                decimal n1 = a + realize_d * 1;
                decimal n2 = a + realize_d * 2;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;

            }
            else if (n == 4)
            {
                decimal n1 = a + realize_d * 1;
                decimal n2 = a + realize_d * 2;
                decimal n3 = a + realize_d * 3;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
            }
            else if(n == 5)
            {
                decimal n1 = a + realize_d * 1;
                decimal n2 = a + realize_d * 2;
                decimal n3 = a + realize_d * 3;
                decimal n4 = a + realize_d * 4;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
                x4 = n4 * n4 * fusionA + n4 * fusionB + fusionC;
            }
            else if (n == 10)
            {
                decimal n1 = a + realize_d * 1;
                decimal n2 = a + realize_d * 2;
                decimal n3 = a + realize_d * 3;
                decimal n4 = a + realize_d * 4;
                decimal n5 = a + realize_d * 5;
                decimal n6 = a + realize_d * 6;
                decimal n7 = a + realize_d * 7;
                decimal n8 = a + realize_d * 8;
                decimal n9 = a + realize_d * 9;

                x0 = a * a * fusionA + a * fusionB + fusionC;
                x1 = n1 * n1 * fusionA + n1 * fusionB + fusionC;
                x2 = n2 * n2 * fusionA + n2 * fusionB + fusionC;
                x3 = n3 * n3 * fusionA + n3 * fusionB + fusionC;
                x4 = n4 * n4 * fusionA + n4 * fusionB + fusionC;
                x5 = n5 * n5 * fusionA + n5 * fusionB + fusionC;
                x6 = n6 * n6 * fusionA + n6 * fusionB + fusionC;
                x7 = n7 * n7 * fusionA + n7 * fusionB + fusionC;
                x8 = n8 * n8 * fusionA + n8 * fusionB + fusionC;
                x9 = n9 * n9 * fusionA + n9 * fusionB + fusionC;
            }
            decimal realize_e = x0 + x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9;

            decimal realize = realize_d * realize_e;

            String realize_number = realize.ToString();
            //answer_label = label4.Text
            answer_label.Text = realize_number;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void 長方形近似法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

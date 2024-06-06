namespace Numerical_integration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            range_a = new TextBox();
            range_b = new TextBox();
            label3 = new Label();
            answer_label = new Label();
            label5 = new Label();
            division = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            menuStrip1 = new MenuStrip();
            長方形近似法ToolStripMenuItem = new ToolStripMenuItem();
            長方形近似法ToolStripMenuItem1 = new ToolStripMenuItem();
            台形近似法ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 92);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "長方形近似法①";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 260);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 1;
            label2.Text = "a=";
            label2.Click += label2_Click;
            // 
            // range_a
            // 
            range_a.Location = new Point(100, 257);
            range_a.Name = "range_a";
            range_a.Size = new Size(200, 39);
            range_a.TabIndex = 2;
            range_a.TextChanged += textBox1_TextChanged;
            // 
            // range_b
            // 
            range_b.Location = new Point(100, 327);
            range_b.Name = "range_b";
            range_b.Size = new Size(200, 39);
            range_b.TabIndex = 3;
            range_b.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 330);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 4;
            label3.Text = "b=";
            label3.Click += label3_Click;
            // 
            // answer_label
            // 
            answer_label.AutoSize = true;
            answer_label.Location = new Point(402, 404);
            answer_label.Name = "answer_label";
            answer_label.Size = new Size(279, 32);
            answer_label.TabIndex = 5;
            answer_label.Text = "ココをクリックして答えを表示";
            answer_label.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 400);
            label5.Name = "label5";
            label5.Size = new Size(44, 32);
            label5.TabIndex = 17;
            label5.Text = "n=";
            // 
            // division
            // 
            division.Location = new Point(100, 397);
            division.Name = "division";
            division.Size = new Size(200, 39);
            division.TabIndex = 18;
            division.TextChanged += textBox14_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 39);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox15_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 180);
            label6.Name = "label6";
            label6.Size = new Size(42, 32);
            label6.TabIndex = 23;
            label6.Text = "y=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 183);
            label7.Name = "label7";
            label7.Size = new Size(54, 32);
            label7.TabIndex = 24;
            label7.Text = "x^2";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(216, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(98, 39);
            textBox5.TabIndex = 25;
            textBox5.TextChanged += textBox16_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 187);
            label8.Name = "label8";
            label8.Size = new Size(25, 32);
            label8.TabIndex = 26;
            label8.Text = "x";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(351, 180);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(98, 39);
            textBox6.TabIndex = 27;
            textBox6.TextChanged += textBox17_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 長方形近似法ToolStripMenuItem, 長方形近似法ToolStripMenuItem1, 台形近似法ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(809, 40);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // 長方形近似法ToolStripMenuItem
            // 
            長方形近似法ToolStripMenuItem.Name = "長方形近似法ToolStripMenuItem";
            長方形近似法ToolStripMenuItem.Size = new Size(202, 36);
            長方形近似法ToolStripMenuItem.Text = "長方形近似法①";
            長方形近似法ToolStripMenuItem.Click += 長方形近似法ToolStripMenuItem_Click;
            // 
            // 長方形近似法ToolStripMenuItem1
            // 
            長方形近似法ToolStripMenuItem1.Name = "長方形近似法ToolStripMenuItem1";
            長方形近似法ToolStripMenuItem1.Size = new Size(202, 36);
            長方形近似法ToolStripMenuItem1.Text = "長方形近似法②";
            長方形近似法ToolStripMenuItem1.Click += 長方形近似法ToolStripMenuItem1_Click;
            // 
            // 台形近似法ToolStripMenuItem
            // 
            台形近似法ToolStripMenuItem.Name = "台形近似法ToolStripMenuItem";
            台形近似法ToolStripMenuItem.Size = new Size(154, 36);
            台形近似法ToolStripMenuItem.Text = "台形近似法";
            台形近似法ToolStripMenuItem.Click += 台形近似法ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 514);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(division);
            Controls.Add(label5);
            Controls.Add(answer_label);
            Controls.Add(label3);
            Controls.Add(range_b);
            Controls.Add(range_a);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "長方形近似法①";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox range_a;
        private TextBox range_b;
        private Label label3;
        private Label answer_label;
        private Label label5;
        private TextBox division;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 長方形近似法ToolStripMenuItem;
        private ToolStripMenuItem 長方形近似法ToolStripMenuItem1;
        private ToolStripMenuItem 台形近似法ToolStripMenuItem;
    }
}

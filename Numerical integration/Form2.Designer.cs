namespace Numerical_integration
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            長方形近似法ToolStripMenuItem = new ToolStripMenuItem();
            長方形近似法ToolStripMenuItem1 = new ToolStripMenuItem();
            台形近似法ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            answer_label = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            range_a = new TextBox();
            range_b = new TextBox();
            division = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 長方形近似法ToolStripMenuItem, 長方形近似法ToolStripMenuItem1, 台形近似法ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 長方形近似法ToolStripMenuItem
            // 
            長方形近似法ToolStripMenuItem.Name = "長方形近似法ToolStripMenuItem";
            長方形近似法ToolStripMenuItem.Size = new Size(202, 36);
            長方形近似法ToolStripMenuItem.Text = "長方形近似法①";
            // 
            // 長方形近似法ToolStripMenuItem1
            // 
            長方形近似法ToolStripMenuItem1.Name = "長方形近似法ToolStripMenuItem1";
            長方形近似法ToolStripMenuItem1.Size = new Size(202, 36);
            長方形近似法ToolStripMenuItem1.Text = "長方形近似法②";
            // 
            // 台形近似法ToolStripMenuItem
            // 
            台形近似法ToolStripMenuItem.Name = "台形近似法ToolStripMenuItem";
            台形近似法ToolStripMenuItem.Size = new Size(154, 36);
            台形近似法ToolStripMenuItem.Text = "台形近似法";
            台形近似法ToolStripMenuItem.Click += 台形近似法ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 88);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 1;
            label1.Text = "長方形近似法②";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 142);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 2;
            label2.Text = "y=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 3;
            label3.Text = "x^2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 149);
            label4.Name = "label4";
            label4.Size = new Size(25, 32);
            label4.TabIndex = 4;
            label4.Text = "x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 348);
            label5.Name = "label5";
            label5.Size = new Size(44, 32);
            label5.TabIndex = 30;
            label5.Text = "n=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 278);
            label6.Name = "label6";
            label6.Size = new Size(44, 32);
            label6.TabIndex = 29;
            label6.Text = "b=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 208);
            label7.Name = "label7";
            label7.Size = new Size(42, 32);
            label7.TabIndex = 28;
            label7.Text = "a=";
            // 
            // answer_label
            // 
            answer_label.AutoSize = true;
            answer_label.Location = new Point(459, 374);
            answer_label.Name = "answer_label";
            answer_label.Size = new Size(279, 32);
            answer_label.TabIndex = 35;
            answer_label.Text = "ココをクリックして答えを表示";
            answer_label.Click += label9_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 39);
            textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(98, 39);
            textBox2.TabIndex = 37;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(368, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 39);
            textBox3.TabIndex = 38;
            // 
            // range_a
            // 
            range_a.Location = new Point(94, 208);
            range_a.Name = "range_a";
            range_a.Size = new Size(200, 39);
            range_a.TabIndex = 39;
            // 
            // range_b
            // 
            range_b.Location = new Point(94, 278);
            range_b.Name = "range_b";
            range_b.Size = new Size(200, 39);
            range_b.TabIndex = 40;
            // 
            // division
            // 
            division.Location = new Point(94, 345);
            division.Name = "division";
            division.Size = new Size(200, 39);
            division.TabIndex = 41;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(division);
            Controls.Add(range_b);
            Controls.Add(range_a);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(answer_label);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "長方形近似法②";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 長方形近似法ToolStripMenuItem;
        private ToolStripMenuItem 長方形近似法ToolStripMenuItem1;
        private ToolStripMenuItem 台形近似法ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label answer_label;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox range_a;
        private TextBox range_b;
        private TextBox division;
    }
}
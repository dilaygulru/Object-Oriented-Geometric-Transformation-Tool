namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(239, 28);
            label1.TabIndex = 0;
            label1.Text = "Center Points              :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(304, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(481, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(39, 113);
            label2.Name = "label2";
            label2.Size = new Size(238, 28);
            label2.TabIndex = 3;
            label2.Text = "Lenght                         :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(304, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 31);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(39, 181);
            label3.Name = "label3";
            label3.Size = new Size(239, 28);
            label3.TabIndex = 5;
            label3.Text = "Number of Edges       :";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(304, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(141, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(304, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 31);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 250);
            label4.Name = "label4";
            label4.Size = new Size(242, 28);
            label4.TabIndex = 7;
            label4.Text = "Ratation Angel            :";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.ForeColor = Color.Black;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(39, 308);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(408, 304);
            listBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(761, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 488);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(490, 371);
            button1.Name = "button1";
            button1.Size = new Size(222, 38);
            button1.TabIndex = 11;
            button1.Text = "Set Random Value";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(490, 436);
            button2.Name = "button2";
            button2.Size = new Size(223, 38);
            button2.TabIndex = 12;
            button2.Text = "Draw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(489, 509);
            button3.Name = "button3";
            button3.Size = new Size(223, 38);
            button3.TabIndex = 13;
            button3.Text = "Rotate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(359, 15);
            label5.Name = "label5";
            label5.Size = new Size(26, 28);
            label5.TabIndex = 14;
            label5.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(541, 15);
            label6.Name = "label6";
            label6.Size = new Size(25, 28);
            label6.TabIndex = 15;
            label6.Text = "Y";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1288, 652);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "SWE 104 Object Oriented Programming";
            TopMost = true;
            TransparencyKey = Color.Brown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
    }
}

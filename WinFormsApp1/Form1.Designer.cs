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
            btn1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dt1 = new DateTimePicker();
            nup = new NumericUpDown();
            txtbox1 = new TextBox();
            txtbox2 = new TextBox();
            txtbox3 = new TextBox();
            txtbox4 = new TextBox();
            txtbox5 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nup).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(686, 381);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 0;
            btn1.Text = "Create";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 29);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 26);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 3;
            label3.Text = "Mother Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 26);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 4;
            label4.Text = "Birth Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(704, 26);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "School ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 118);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 6;
            label6.Text = "Career";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(237, 118);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 7;
            label7.Text = "Grade";
            // 
            // dt1
            // 
            dt1.Location = new Point(446, 44);
            dt1.Name = "dt1";
            dt1.Size = new Size(200, 23);
            dt1.TabIndex = 8;
            // 
            // nup
            // 
            nup.Location = new Point(193, 136);
            nup.Name = "nup";
            nup.Size = new Size(120, 23);
            nup.TabIndex = 9;
            // 
            // txtbox1
            // 
            txtbox1.Location = new Point(12, 44);
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(100, 23);
            txtbox1.TabIndex = 10;
            txtbox1.TextChanged += textBox1_TextChanged;
            // 
            // txtbox2
            // 
            txtbox2.Location = new Point(152, 47);
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new Size(100, 23);
            txtbox2.TabIndex = 11;
            txtbox2.TextChanged += txtbox2_TextChanged;
            // 
            // txtbox3
            // 
            txtbox3.Location = new Point(295, 44);
            txtbox3.Name = "txtbox3";
            txtbox3.Size = new Size(100, 23);
            txtbox3.TabIndex = 12;
            txtbox3.TextChanged += textBox3_TextChanged;
            // 
            // txtbox4
            // 
            txtbox4.Location = new Point(686, 44);
            txtbox4.Name = "txtbox4";
            txtbox4.Size = new Size(100, 23);
            txtbox4.TabIndex = 13;
            // 
            // txtbox5
            // 
            txtbox5.Location = new Point(-3, 136);
            txtbox5.Name = "txtbox5";
            txtbox5.Size = new Size(100, 23);
            txtbox5.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(546, 381);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(txtbox5);
            Controls.Add(txtbox4);
            Controls.Add(txtbox3);
            Controls.Add(txtbox2);
            Controls.Add(txtbox1);
            Controls.Add(nup);
            Controls.Add(dt1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dt1;
        private NumericUpDown nup;
        private TextBox txtbox1;
        private TextBox txtbox2;
        private TextBox txtbox3;
        private TextBox txtbox4;
        private TextBox txtbox5;
        private TextBox textBox1;
    }
}
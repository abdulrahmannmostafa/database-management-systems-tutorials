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
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 27);
            label1.Name = "label1";
            label1.Size = new Size(182, 41);
            label1.TabIndex = 0;
            label1.Text = "Application";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(592, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 128);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 128);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 6;
            label3.Text = "Total Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 256);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 7;
            label4.Text = "Age";
            // 
            // button1
            // 
            button1.Location = new Point(257, 360);
            button1.Name = "button1";
            button1.Size = new Size(205, 41);
            button1.TabIndex = 8;
            button1.Text = "Submit Application";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(123, 283);
            label5.Name = "label5";
            label5.Size = new Size(196, 20);
            label5.TabIndex = 9;
            label5.Text = "Age must be a valid number";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(123, 303);
            label6.Name = "label6";
            label6.Size = new Size(215, 20);
            label6.TabIndex = 10;
            label6.Text = "Age must be between 8 and 60";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(496, 164);
            label7.Name = "label7";
            label7.Size = new Size(246, 20);
            label7.TabIndex = 11;
            label7.Text = "Total Salary must be a valid number";
            label7.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(467, 206);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Net Salary";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(496, 243);
            label8.Name = "label8";
            label8.Size = new Size(211, 20);
            label8.TabIndex = 13;
            label8.Text = "Final salary can't be less than 0";
            label8.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private Label label8;
    }
}

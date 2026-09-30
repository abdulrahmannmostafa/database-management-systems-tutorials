namespace WinFormsApp1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 41);
            label1.TabIndex = 0;
            label1.Text = "Expenses Tracker";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(359, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(626, 23);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 26);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 26);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Salary";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Transport", "Bills", "Shopping", "Entertainment", "Utilities" });
            comboBox1.Location = new Point(12, 125);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(692, 81);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 7;
            label5.Text = "Total:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(692, 102);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 8;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(692, 357);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 10;
            label7.Text = "0.0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(692, 334);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 9;
            label8.Text = "Average:";
            // 
            // button1
            // 
            button1.Location = new Point(189, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 210);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 13;
            label9.Text = "Amount";
            // 
            // button2
            // 
            button2.Location = new Point(189, 233);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 14;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 316);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2026, 10, 1, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Category, Amount, Date });
            dataGridView1.Location = new Point(290, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(396, 273);
            dataGridView1.TabIndex = 16;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(424, 357);
            label10.Name = "label10";
            label10.Size = new Size(122, 20);
            label10.TabIndex = 17;
            label10.Text = "lblErrorDuplicate";
            label10.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox textBox3;
        private Label label9;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label10;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Date;
    }
}
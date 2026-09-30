using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        private readonly string name;
        private readonly double salary;
        public Form2(string name, double salary)
        {
            InitializeComponent();
            this.name = name;
            this.salary = salary;

            textBox1.Text = name;
            textBox2.Text = salary.ToString("C");

            dataGridView1.Columns["Amount"]!.DefaultCellStyle.Format = "C2";
        }

        private bool isValidEntry(object? category, object? date)
        {
            return category?.ToString() == comboBox1.SelectedItem?.ToString() &&
                   date?.ToString() == dateTimePicker1.Value.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Category and Amount fields can’t be empty!");
                return;
            }

            if (!double.TryParse(textBox3.Text, out double result) || result <= 0)
            {
                MessageBox.Show("Amount must be a positive number!");
                return;
            }

            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Date cannot be in the past!");
                return;
            }

            bool entryExists = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (isValidEntry(
                    row.Cells["Category"].Value,
                    row.Cells["Date"].Value))
                {
                    entryExists = true;
                    break;
                }
            }

            if (entryExists)
            {
                label10.Visible = true;
                return;
            }

            label10.Visible = false;


            double.TryParse(textBox3.Text, out double amount);
            double totalAmount = result;
            totalAmount += double.Parse(label6.Text, System.Globalization.NumberStyles.Currency);

            if (totalAmount > salary)
            {
                MessageBox.Show("Total amount exceeds the salary!");
                return;
            }

            dataGridView1.Rows.Add(comboBox1.SelectedItem, result, dateTimePicker1.Value.ToShortDateString());

            comboBox1.SelectedIndex = -1;
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Today;


            label6.Text = totalAmount.ToString("C");
            label7.Text = (totalAmount / dataGridView1.Rows.Count).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label6.Text = "0";
            label7.Text = "0.00";
            label10.Visible = false;
        }
    }
}
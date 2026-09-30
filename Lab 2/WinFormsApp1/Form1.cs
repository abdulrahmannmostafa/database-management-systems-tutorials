using System.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double totalSalary = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValidName(string name)
        {
            return name.All(char.IsLetter);
        }

        private bool isValidAge(string age)
        {
            return int.TryParse(age, out int result) && result > 0;
        }

        private bool isValidSalary(string salary)
        {
            return double.TryParse(salary, out double result) && result > 0;
        }

        private bool isAgeInRange(string age)
        {
            if (int.TryParse(age, out int result))
            {
                return result >= 8 && result <= 60;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }



            if (!isValidName(textBox1!.Text))
            {
                MessageBox.Show("Name must contain only characters!");
                return;

            }

            bool validAge = isValidAge(textBox3!.Text);
            label5.Visible = !validAge;

            if (!validAge)
            {
                return;
            }



            bool ageInRange = isAgeInRange(textBox3!.Text);
            label6.Visible = !ageInRange;

            if(!ageInRange)
            {
                return;
            }


            bool validSalary = isValidSalary(textBox2!.Text);
            label7.Visible = !validSalary;

            if(!validSalary)
            {
                return;
            }

            totalSalary = double.Parse(textBox2.Text);

            if (checkBox1.Checked)
            {
                totalSalary -= 2000;
            }

            label8.Visible = totalSalary < 0;

            if(totalSalary < 0)
            {
                return;
            }

            Form2 form2 = new Form2(textBox1.Text, totalSalary);
            form2.FormClosed += (s, args) => this.Close();

            form2.Show();
            this.Hide();

        }
    }
}

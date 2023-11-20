using System.Globalization;

namespace DataBase
{
    public partial class Form1 : Form
    {
        private string name = string.Empty;
        private string surname = string.Empty;
        private string gender = string.Empty;
        private string dateOfBirth = string.Empty;
        private string info = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text == "")
            {
                MessageBox.Show("please enter your name");
                return;
            }
            if (tbSurname.Text == null || tbSurname.Text == "")
            {
                MessageBox.Show("please enter your surname");
                return;
            }
            if (dateTimePicker1.Text == null || dateTimePicker1.Text == "")
            {
                MessageBox.Show("please enter your date of birth");
                return;
            }
            if (!rbFemale.Checked && !rbMale.Checked)
            {
                MessageBox.Show("please enter your gender");
                return;
            }
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("the date of birth is invalid");
                return;
            }
            else
            {
                name = tbName.Text;
                surname = tbSurname.Text;
                dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                if (rbFemale.Checked)
                {
                    gender = rbFemale.Text;
                }
                info = $"{name} {surname} {dateOfBirth} {gender}";
                listBox1.Items.Add(info);


                Clear();
            }
        }

        private void Clear()
        {
            tbName.Clear();
            tbSurname.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Clear();
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select an item from the ListBox.");
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                info = listBox1.SelectedItem.ToString();
                string[] parts = info.Split(' ');
                name = parts[0];
                surname = parts[1];
                dateOfBirth = parts[2];
                gender = parts[3];
                tbName.Text = name;
                tbSurname.Text = surname;
                dateTimePicker1.Value = DateTime.ParseExact(dateOfBirth, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                if (gender == "Female")
                {
                    rbFemale.Checked = true;
                }
                if (gender == "Male")
                {
                    rbMale.Checked = true;
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Check if the selected index is within the bounds of the ListBox items
                if (listBox1.SelectedIndex < listBox1.Items.Count)
                {
                    name = tbName.Text;
                    surname = tbSurname.Text;
                    dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    if (rbMale.Checked)
                    {
                        gender = rbMale.Text;
                    }
                    if (rbFemale.Checked)
                    {
                        gender = rbFemale.Text;
                    }

                    // Update the ListBox item with the modified information
                    listBox1.Items[listBox1.SelectedIndex] = $"{name} {surname} {dateOfBirth} {gender}";
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the ListBox to edit.");
            }
        }
    }
}

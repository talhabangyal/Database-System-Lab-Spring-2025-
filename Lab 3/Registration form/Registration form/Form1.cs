using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateCountries();
        }
        
        private void PopulateCountries()
        {
            List<string> countriesList = new List<string>()
            {
                "United States", "Canada", "United Kingdom", "Australia", "India",
                "Germany", "France", "Italy", "Spain", "Mexico", "Brazil", "China",
                "Japan", "Russia", "South Korea", "South Africa", "Argentina", "Egypt"
            };
            countries.DataSource = countriesList;
        }
        
        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void f_name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_Click(object sender, EventArgs e)
        {

        }

        private void l_name_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpassword_Click(object sender, EventArgs e)
        {

        }

        private void c_password_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void terms_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void register_Click(object sender, EventArgs e)
        {
            string firstName = f_name_input.Text;
            string lastName = l_name_input.Text;
            string email = email_input.Text;
            string password = password_input.Text;
            string confirmPassword = c_password_input.Text;
            string gender = "";
            string country = countries.SelectedItem.ToString();
            
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else if (other.Checked)
                gender = "Other";
            
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password must match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!terms.Checked)
            {
                MessageBox.Show("You must accept the terms and conditions.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            StringBuilder registrationDetails = new StringBuilder();
            registrationDetails.AppendLine("Registration Details:");
            registrationDetails.AppendLine($"First Name: {firstName}");
            registrationDetails.AppendLine($"Last Name: {lastName}");
            registrationDetails.AppendLine($"Email: {email}");
            registrationDetails.AppendLine($"Gender: {gender}");
            registrationDetails.AppendLine($"Country: {country}");
            registrationDetails.AppendLine("Registration Successful!");

            MessageBox.Show(registrationDetails.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            ResetForm();
        }
        
        private void ResetForm()
        {
            f_name_input.Clear();
            l_name_input.Clear();
            email_input.Clear();
            password_input.Clear();
            c_password_input.Clear();
            male.Checked = false;
            female.Checked = false;
            other.Checked = false;
            countries.SelectedIndex = -1;
            terms.Checked = false;
        }
    }
}

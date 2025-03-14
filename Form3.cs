using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acitivity
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            cmbYear.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorName.Clear();
            errorAge.Clear();
            errorAddress.Clear();
            errorContactNum.Clear();
            errorCourse.Clear();
            errorYear.Clear();
            errorEmail.Clear();
            errorGuardian.Clear();
            errorGuardianNum.Clear();

            bool hasError = false;

            // Validate required fields
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorName.SetError(txtName, "Name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtAge.Text) || !Regex.IsMatch(txtAge.Text, @"^\d+$"))
            {
                errorAge.SetError(txtAge, "Age must be a number.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorAddress.SetError(txtAddress, "Address is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtContactNum.Text) || !Regex.IsMatch(txtContactNum.Text, @"^\d+$"))
            {
                errorContactNum.SetError(txtContactNum, "Contact number must be a number.");
                hasError = true;
            }
            if (cmbCourse.SelectedIndex == -1)
            {
                errorCourse.SetError(cmbCourse, "Course is required.");
                hasError = true;
            }
            if (cmbYear.SelectedIndex == -1)
            {
                errorYear.SetError(cmbYear, "Year is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorEmail.SetError(txtEmail, "Email is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtGuardian.Text))
            {
                errorGuardian.SetError(txtGuardian, "Guardian name is required.");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(txtGuardianNum.Text) || !Regex.IsMatch(txtGuardianNum.Text, @"^\d+$"))
            {
                errorGuardianNum.SetError(txtGuardianNum, "Guardian contact must be a number.");
                hasError = true;
            }

            // If no errors, save profile
            if (!hasError)
            {
                MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

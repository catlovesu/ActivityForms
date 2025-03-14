using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acitivity
{
    public partial class Form1 : Form
    {
        private string mockUsername = "Sandara";
        private string mockPassword = "123";
        private int loginAttempts = 0;
        private const int maxLoginAttempts = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            if (enteredUsername == mockUsername && enteredPassword == mockPassword)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form2 studentForm = new Form2();
                studentForm.ShowDialog(); 
                this.Close(); 
            }
            loginAttempts++;

          
            if (string.IsNullOrEmpty(enteredUsername) && string.IsNullOrEmpty(enteredPassword))
            {
                errorUsername.SetError(txtUsername, "Username is required!");
                errorUsername.SetError(txtPassword, "Password is required!");
            }
            else if (string.IsNullOrEmpty(enteredUsername))
            {
                errorUsername.SetError(txtUsername, "Username is required!");
                errorPassword.SetError(txtPassword, ""); 
            }
            else if (string.IsNullOrEmpty(enteredPassword))
            {
                errorPassword.SetError(txtPassword, "Password is required!");
                errorUsername.SetError(txtUsername, "");
            }
            else if (enteredUsername != mockUsername && enteredPassword != mockPassword)
            {
                errorUsername.SetError(txtUsername, "Incorrect username.");
                errorPassword.SetError(txtPassword, "Incorrect password.");
            }
            else if (enteredUsername != mockUsername)
            {
                errorUsername.SetError(txtUsername, "Incorrect username.");
                errorPassword.SetError(txtPassword, "");
            }
            else if (enteredPassword != mockPassword)
            {
                errorPassword.SetError(txtPassword, "Incorrect password.");
                errorUsername.SetError(txtUsername, ""); 
            }

            
            if (loginAttempts >= maxLoginAttempts)
            {
                MessageBox.Show("Maximum attempts reached! Reset your password here:\nhttps://resetpassword.com",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLogin.Enabled = false; 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        

       

        }
    }
}

using A3_M2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_M2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            emailBox.KeyPress += TextBox_KeyPress;
            passwordBox.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Simulate a click on the login button
                loginButton.PerformClick();
            }
        }
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (emailBox.Text == "")
                {
                    emailBox.Text = "";
                    emailBox.ForeColor = Color.Gray;
                    return;
                }
                emailBox.ForeColor = Color.White;
                invalidMsg.Visible = false;
            }
            catch { }

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (passwordBox.Text == "")
                {
                    passwordBox.Text = "";
                    passwordBox.ForeColor = Color.Gray;
                    return;
                }
                passwordBox.ForeColor = Color.White;
                passwordBox.PasswordChar = '*';
                error2.Visible = false;
            }
            catch { }

        }


        private void emailBox_Click(object sender, EventArgs e)
        {
            emailBox.SelectAll();

        }

        private void passwordBox_Click(object sender, EventArgs e)
        {
            passwordBox.SelectAll();
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Black;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.ForeColor = Color.Lime;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login l = new login();
            string result = l.CheckUserCredentials(emailBox.Text, passwordBox.Text);

            // Display the result or take appropriate action
            if (result.Equals("Credentials are valid"))
            {
                Dashboard db = new Dashboard(emailBox.Text);
                // Valid credentials, you can proceed with further actions
                db.Show();
                this.Close();
            }
            else
            {
                // Invalid credentials or an error occurred
                MessageBox.Show(result);
            }
        }

        private void forgetLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contact Alpha Developers on i200623@cfd.nu.edu.pk to restore password");
        }

        private void panellogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

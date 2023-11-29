using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_M2
{
    public partial class templateForm : Form
    {
        string username;
        public templateForm(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameLabel.Text = username;
        }

        private void farmersButton_MouseEnter(object sender, EventArgs e)
        {
            farmersButton.ForeColor = Color.Black;
        }

        private void farmersButton_MouseLeave(object sender, EventArgs e)
        {
            farmersButton.ForeColor = Color.Lime;
        }

        private void productsButton_MouseEnter(object sender, EventArgs e)
        {
            productsButton.ForeColor = Color.Black;
        }

        private void productsButton_MouseLeave(object sender, EventArgs e)
        {
            productsButton.ForeColor = Color.Lime;
        }

        private void creditsButton_MouseEnter(object sender, EventArgs e)
        {
            creditsButton.ForeColor = Color.Black;
        }

        private void creditsButton_MouseLeave(object sender, EventArgs e)
        {
            creditsButton.ForeColor = Color.Lime;
        }

        private void companyButton_MouseEnter(object sender, EventArgs e)
        {
            companyButton.ForeColor = Color.Black;
        }

        private void companyButton_MouseLeave(object sender, EventArgs e)
        {
            companyButton.ForeColor = Color.Lime;
        }

        private void reportButton_MouseEnter(object sender, EventArgs e)
        {
            reportButton.ForeColor = Color.Black;
        }

        private void reportButton_MouseLeave(object sender, EventArgs e)
        {
            reportButton.ForeColor = Color.Lime;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Logged Out");
            this.Close();
        }
    }
}

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
using System.Data.SqlClient;

namespace A3_M2
{
    public partial class transactionForm : Form
    {
        string username;
        public transactionForm(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameLabel.Text = username;

            this.StartPosition = FormStartPosition.CenterScreen;
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
            Application.Exit();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productForm pF = new productForm(username);
            pF.Show();
            this.Close();
        }


        private void companyLogoNav_Click(object sender, EventArgs e)
        {

        }

        private void companyButton_Click(object sender, EventArgs e)
        {
            companyForm cF = new companyForm(username);
            cF.Show();
            this.Close();
        }

        private void farmersButton_Click_1(object sender, EventArgs e)
        {
            farmersForm fF = new farmersForm(username);
            fF.Show();
            this.Close();
        }


        private void filterByBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
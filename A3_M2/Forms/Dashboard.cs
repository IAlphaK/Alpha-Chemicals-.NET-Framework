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
    public partial class Dashboard : Form
    {
        string username;
        public Dashboard(string username)
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

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loggedUserInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void imagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void companyLogoNav_Click(object sender, EventArgs e)
        {

        }

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportButton_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void companyButton_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void creditsButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsButton_Click(object sender, EventArgs e)
        {

        }

        private void navPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void farmersButton_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numOrders_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numFarmers_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numCompany_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numCredits_Click(object sender, EventArgs e)
        {

        }
    }
}

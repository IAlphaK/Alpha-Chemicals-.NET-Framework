using A3_M2.Models;
using System;
using System.Windows.Forms;

namespace A3_M2.Forms
{
    public partial class companyEditForm : Form
    {
        string username;
        public companyEditForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void setfields(int farmerId, string name, string address, string contactInfo, decimal balance)
        {
            // Set the values of the textboxes based on the passed data
            insFarmerID.Text = farmerId.ToString();
            insName.Text = name;
            insAddress.Text = address;
            insContact.Text = contactInfo;
            insBalance.Text = balance.ToString();

            // Disable editing of FarmerID textbox
            insFarmerID.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            companyForm cF = new companyForm(username);
            cF.Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (validateinput())
            {
                Company company = new Company();
                company.UpdateCompany(int.Parse(insFarmerID.Text), insName.Text, insAddress.Text, insContact.Text, Decimal.Parse(insBalance.Text));
                companyForm cF = new companyForm(username);
                cF.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter correct data in the fields");
            }
        }

        private bool validateinput()
        {
            try
            {
                int id;
                if (!int.TryParse(insFarmerID.Text, out id))
                {
                    MessageBox.Show("Invalid ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Convert insBalance to decimal
                decimal balance;
                if (!decimal.TryParse(insBalance.Text, out balance))
                {
                    MessageBox.Show("Invalid balance format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Other methods and events for your farmersEditForm...
    }
}

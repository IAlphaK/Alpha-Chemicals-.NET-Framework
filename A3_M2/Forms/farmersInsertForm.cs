using System;
using System.Windows.Forms;

namespace A3_M2.Forms
{
    public partial class farmersInsertForm : Form
    {
        string username;
        public farmersInsertForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            farmersForm fF = new farmersForm(username);
            fF.Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Validate input before insertion
            if (ValidateInput())
            {
                // Perform insertion
                if (InsertData())
                {
                    // Close the form and notify the main form that the insertion was successful
                    this.DialogResult = DialogResult.OK;
                    farmersForm fF = new farmersForm(username);
                    fF.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insertion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Example validation method (customize based on your requirements)
        private bool ValidateInput()
        {
            return !string.IsNullOrWhiteSpace(insName.Text)
                && !string.IsNullOrWhiteSpace(insAddress.Text)
                && !string.IsNullOrWhiteSpace(insContact.Text)
                && !string.IsNullOrWhiteSpace(insBalance.Text);
        }

        // Example insertion method (customize based on your requirements)
        private bool InsertData()
        {
            try
            {
                // Convert insBalance to decimal
                decimal balance;
                if (!decimal.TryParse(insBalance.Text, out balance))
                {
                    MessageBox.Show("Invalid balance format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Create an instance of the Farmer class
                Farmer farmer = new Farmer();

                // Perform the insertion
                if (farmer.InsertFarmer(int.Parse(insFarmerID.Text), insName.Text, insAddress.Text, insContact.Text, balance))
                {
                    MessageBox.Show("Insertion successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Insertion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Other methods and events for your farmersInsertForm...
    }
}

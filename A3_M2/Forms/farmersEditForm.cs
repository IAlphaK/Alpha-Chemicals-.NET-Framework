using System;
using System.Windows.Forms;

namespace A3_M2.Forms
{
    public partial class farmersEditForm : Form
    {
        string username;
        public farmersEditForm(string username)
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
            farmersForm fF = new farmersForm(username);
            fF.Show();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (validateinput())
            {
                Farmer farmer = new Farmer();
                farmer.UpdateFarmer(int.Parse(insFarmerID.Text), insName.Text, insAddress.Text, insContact.Text, Decimal.Parse(insBalance.Text));
                farmersForm fF = new farmersForm(username);
                fF.Show();
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

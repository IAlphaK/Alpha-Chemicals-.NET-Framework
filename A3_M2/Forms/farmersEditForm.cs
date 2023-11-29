using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void setfields(int productId, string name, decimal price, string policy, int quantity, string batchNo, DateTime expiryDate, string description)
        {

            // Set the values of the textboxes based on the passed data
            insFarmerID.Text = productId.ToString();
            insName.Text = name;
            insContact.Text = price.ToString();
            insPolicy.Text = policy;
            insQuantity.Text = quantity.ToString();
            insBatch.Text = batchNo;
            insExpiry.Text = expiryDate.ToString("yyyy-MM-dd");
            insAddress.Text = description;

            // Disable editing of ProductID textbox
            insFarmerID.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            productForm pF = new productForm(username);
            pF.Show();
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (validateinput())
            {
                product p = new product();
                p.UpdateProduct(int.Parse(insFarmerID.Text), insName.Text, Decimal.Parse(insContact.Text), insBatch.Text, insPolicy.Text, insAddress.Text, int.Parse(insQuantity.Text), DateTime.Parse(insExpiry.Text));
                productForm pF = new productForm(username);
                pF.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter correct data in the fields");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

                // Convert insPrice to decimal
                decimal price;
                if (!decimal.TryParse(insContact.Text, out price))
                {
                    MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Convert insQuantity to int
                int quantity;
                if (!int.TryParse(insQuantity.Text, out quantity))
                {
                    MessageBox.Show("Invalid quantity format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Convert insExp to DateTime
                DateTime expDate;
                if (!DateTime.TryParse(insExpiry.Text, out expDate))
                {
                    MessageBox.Show("Invalid expiration date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

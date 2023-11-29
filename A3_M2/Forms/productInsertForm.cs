using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace A3_M2.Forms
{
    public partial class productInsertForm : Form
    {
        string username;
        public productInsertForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            productForm pF = new productForm(username);
            pF.Show();
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
                    productForm pF = new productForm(username);
                    pF.Show();
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
                && !string.IsNullOrWhiteSpace(insPrice.Text)
                && !string.IsNullOrWhiteSpace(insBatch.Text)
                && !string.IsNullOrWhiteSpace(insPolicy.Text)
                && !string.IsNullOrWhiteSpace(insDesc.Text)
                && !string.IsNullOrWhiteSpace(insQuantity.Text)
                && !string.IsNullOrWhiteSpace(insExp.Text)
                && !string.IsNullOrWhiteSpace(insID.Text);
        }

        // Example insertion method (customize based on your requirements)
        private bool InsertData()
        {
            try
            {
                int id;
                if (!int.TryParse(insID.Text, out id))
                {
                    MessageBox.Show("Invalid ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Convert insPrice to decimal
                decimal price;
                if (!decimal.TryParse(insPrice.Text, out price))
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
                if (!DateTime.TryParse(insExp.Text, out expDate))
                {
                    MessageBox.Show("Invalid expiration date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                product p = new product();
                p.InsertProduct(id, insName.Text, price, insBatch.Text, insPolicy.Text, insDesc.Text, quantity, expDate);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Other methods and events for your InsertProductForm
    }
}


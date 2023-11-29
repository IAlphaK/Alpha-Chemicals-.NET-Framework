using A3_M2.Forms;
using A3_M2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_M2
{
    public partial class productForm : Form
    {
        string username;
        private int rowsPerPage = 10;
        public productForm(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameLabel.Text = username;
            searchBox.Height = 50;



            searchBox.Enter += searchBox_MouseEnter;
            sortByBox.Leave += searchBox_MouseLeave;

            sortByBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            filterByBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            rowsByBox.SelectedIndexChanged += rowsByBox_SelectedIndexChanged;

            productView.CellContentClick += productView_CellContentClick;

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

        private void productForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alpha_chemicalsDataSet2.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.alpha_chemicalsDataSet2.Product);
            // TODO: This line of code loads data into the 'alpha_chemicalsDataSet.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.alpha_chemicalsDataSet.Product);


            rowsByBox.SelectedIndex = 0; // Assuming the default value is at index 0
            rowsByBox_SelectedIndexChanged(rowsByBox, EventArgs.Empty);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            string searchText = searchBox.Text.Trim();

            // Filter the data in the DataTable based on the search text
            alpha_chemicalsDataSet2.Product.DefaultView.RowFilter = $"Name LIKE '%{searchText}%'";

            // Update the DataGridView with the filtered data
            productView.DataSource = alpha_chemicalsDataSet2.Product.DefaultView.ToTable();
        }

        private void searchBox_MouseEnter(object sender, EventArgs e)
        {

            if (searchBox.Text == "Search")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.White;
                ApplyPagination();
            }
        }

        private void searchBox_MouseLeave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected column name from the sortByBox
            string selectedColumn = sortByBox.SelectedItem?.ToString();

            // Get the selected sort order from the filterByBox, defaulting to "DESC"
            string sortOrder = filterByBox.SelectedItem?.ToString() ?? "DESC";

            // Sort the DataGridView based on the selected column and sort order
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                alpha_chemicalsDataSet2.Product.DefaultView.Sort = $"{selectedColumn} {sortOrder}";
                ApplyPagination();
            }
        }

        private void rowsByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected number of rows per page from the rowsByBox
            int.TryParse(rowsByBox.SelectedItem?.ToString(), out rowsPerPage);

            // Apply pagination independently of other filters
            ApplyPagination();
        }

        private void SetRowBackgroundColor(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }

        // Helper method to apply pagination and update the DataGridView
        private void ApplyPagination()
        {
            // Clone the DefaultView to avoid affecting the original sorting
            DataView sortedView = alpha_chemicalsDataSet2.Product.DefaultView.ToTable().DefaultView;

            // Display only the specified number of rows
            DataTable paginatedTable = sortedView.ToTable().AsEnumerable().Take(rowsPerPage).CopyToDataTable();

            productView.DataSource = paginatedTable;
        }

        private void productView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productView.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < productView.Columns.Count)
            {
                DataGridViewColumn clickedColumn = productView.Columns[e.ColumnIndex];

                if (clickedColumn != null)
                {

                    if (clickedColumn.Name == "Delete")
                    {
                        // Confirm deletion with the user
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this row? Any Related Transactions/Ledgers with corresponding ID in other tables will also be deleted", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Get the ID of the selected row
                            int productId = Convert.ToInt32(productView.Rows[e.RowIndex].Cells[0].Value);

                            product p = new product();
                            // Assuming you have a method to delete a row by ID, replace "DeleteProduct" with your actual method
                            if (p.DeleteProduct(productId))
                            {
                                MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView after deletion
                                this.productTableAdapter1.Fill(this.alpha_chemicalsDataSet2.Product);
                                ApplyPagination();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (clickedColumn.Name == "Update")
                    {
                        if (MessageBox.Show("Are you sure you want to edit this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int productId = Convert.ToInt32(productView.Rows[e.RowIndex].Cells[0].Value);

                            // Fetch the data of the selected row based on productId
                            // Assuming you have a method to retrieve a product by ID, replace "GetProductByID" with your actual method
                            product p = new product();
                            product selectedProduct = p.GetProductByID(productId);

                            // Create an instance of productEditForm and pass the data
                            productEditForm editForm = new productEditForm(username);
                            editForm.setfields(selectedProduct.ProductID, selectedProduct.Name, selectedProduct.Price, selectedProduct.Policy, selectedProduct.Quantity, selectedProduct.BatchNo, selectedProduct.ExpiryDate, selectedProduct.Description);

                            // Show the editForm and close the current form
                            editForm.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productInsertForm insertForm = new productInsertForm(username);
            insertForm.Show();
            this.Close();
            this.productTableAdapter1.Fill(this.alpha_chemicalsDataSet2.Product);
            ApplyPagination();
        }
    }

    
}

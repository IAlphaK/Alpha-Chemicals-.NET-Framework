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
    public partial class farmersForm : Form
    {
        string username;
        private int rowsPerPage = 10;
        public farmersForm(string username)
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

            farmersView.CellContentClick += farmersView_CellContentClick;
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
            // TODO: This line of code loads data into the 'alpha_chemicalsDataSet3.Farmer' table. You can move, or remove it, as needed.
            this.farmerTableAdapter.Fill(this.alpha_chemicalsDataSet3.Farmer);
            // TODO: This line of code loads data into the 'alpha_chemicalsDataSet2.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.alpha_chemicalsDataSet2.Product);
            // TODO: This line of code loads data into the 'alpha_chemicalsDataSet.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.alpha_chemicalsDataSet.Product);


            rowsByBox.SelectedIndex = 0; // Assuming the default value is at index 0
            rowsByBox_SelectedIndexChanged(rowsByBox, EventArgs.Empty);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            string searchText = searchBox.Text.Trim();

            // Filter the data in the DataTable based on the search text
            alpha_chemicalsDataSet3.Farmer.DefaultView.RowFilter = $"Name LIKE '%{searchText}%'";

            // Update the DataGridView with the filtered data
            farmersView.DataSource = alpha_chemicalsDataSet3.Farmer.DefaultView.ToTable();
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
                alpha_chemicalsDataSet3.Farmer.DefaultView.Sort = $"{selectedColumn} {sortOrder}";
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
            
            try
            {
                // Clone the DefaultView to avoid affecting the original sorting
                DataView sortedView = alpha_chemicalsDataSet3.Farmer.DefaultView.ToTable().DefaultView;

                // Display only the specified number of rows
                DataTable paginatedTable = sortedView.ToTable().AsEnumerable().Take(rowsPerPage).CopyToDataTable();

                farmersView.DataSource = paginatedTable;
            }

            catch (Exception ex) 
            { 
            }

            
        }

        private void farmersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < farmersView.Rows.Count && e.ColumnIndex >= 0 && e.ColumnIndex < farmersView.Columns.Count)
            {
                DataGridViewColumn clickedColumn = farmersView.Columns[e.ColumnIndex];

                if (clickedColumn != null)
                {
                    if (clickedColumn.Name == "Delete")
                    {
                        // Confirm deletion with the user
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Get the ID of the selected row
                            int farmerId = Convert.ToInt32(farmersView.Rows[e.RowIndex].Cells[0].Value);

                            Farmer farmer = new Farmer();
                            // Assuming you have a method to delete a row by ID, replace "DeleteFarmer" with your actual method
                            if (farmer.DeleteFarmer(farmerId))
                            {
                                MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView after deletion
                                this.farmerTableAdapter.Fill(this.alpha_chemicalsDataSet3.Farmer);
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
                            int farmerId = Convert.ToInt32(farmersView.Rows[e.RowIndex].Cells[0].Value);

                            // Fetch the data of the selected row based on farmerId
                            // Assuming you have a method to retrieve a farmer by ID, replace "GetFarmerByID" with your actual method
                            Farmer farmer = new Farmer();
                            Farmer selectedFarmer = farmer.GetFarmerByID(farmerId);

                            // Create an instance of farmersEditForm and pass the data
                            farmersEditForm editForm = new farmersEditForm(username);
                            editForm.setfields(selectedFarmer.FarmerID, selectedFarmer.Name, selectedFarmer.Address, selectedFarmer.ContactInfo, selectedFarmer.Balance);

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
            farmersInsertForm insertForm = new farmersInsertForm(username);
            insertForm.Show();
            this.Close();
            this.farmerTableAdapter.Fill(this.alpha_chemicalsDataSet3.Farmer);
            ApplyPagination();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            productForm pF = new productForm(username);
            pF.Show();
            this.Close();
        }

        private void companyLogoNav_Click(object sender, EventArgs e)
        {
            Dashboard df = new Dashboard(username);
            df.Show();
            this.Close();

        }
    }

    
}

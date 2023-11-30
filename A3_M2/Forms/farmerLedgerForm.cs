using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_M2.Forms
{
    public partial class farmerLedgerForm : Form
    {
        int ID;
        public farmerLedgerForm(int ID)
        {
            InitializeComponent();
            this.ID = ID;

            LoadFarmerLedgerData();

            sortByBox.SelectedIndexChanged += sortByBox_SelectedIndexChanged;
            filterByBox.SelectedIndexChanged += sortByBox_SelectedIndexChanged;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFarmerLedgerData()
        {
            // Use the selectedFarmerID in your SQL query
            string query = $@"
            SELECT
                F.FarmerID,
                F.Name,
                TS.TS_ID,
                TS.ProductID,
                TS.TypeID,
                TS.Status,
                TS.Transaction_Date,
                TS.Amount
            FROM
                dbo.Farmer AS F
            INNER JOIN
                dbo.Transact_Sell AS TS ON F.FarmerID = TS.FarmerID
            WHERE
                F.FarmerID = {ID};";

            // Assuming you have a method to execute the query and return a DataTable
            DataTable dataTable = ExecuteQueryAndGetDataTable(query);

            // Set the DataTable as the DataSource for the DataGridView
            farmerLedgerView.DataSource = dataTable;
        }

        // Add a method to execute the query and return a DataTable
        private DataTable ExecuteQueryAndGetDataTable(string query)
        {
            // Implement the logic to execute the query and get the DataTable
            // For example, use SqlDataAdapter and SqlConnection
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void sortByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected column name from the sortByBox
            string selectedColumn = sortByBox.SelectedItem?.ToString();

            // Get the selected sort order from the filterByBox, defaulting to "DESC"
            string sortOrder = filterByBox.SelectedItem?.ToString() ?? "DESC";

            
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                // Assuming farmerLedgerView is your DataGridView
                ((DataTable)farmerLedgerView.DataSource).DefaultView.Sort = $"{selectedColumn} {sortOrder}";

                // Refresh the DataGridView
                farmerLedgerView.Refresh();
            }
        }
    }

}

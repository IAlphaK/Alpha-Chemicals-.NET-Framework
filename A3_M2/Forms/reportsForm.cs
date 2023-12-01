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
using OfficeOpenXml;
using System.IO;

namespace A3_M2
{
    public partial class reportsForm : Form
    {
        string username;
        public reportsForm(string username)
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
            transactionsButton.ForeColor = Color.Black;
        }

        private void creditsButton_MouseLeave(object sender, EventArgs e)
        {
            transactionsButton.ForeColor = Color.Lime;
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

        private void farmersButton_Click(object sender, EventArgs e)
        {
            
        }
        private DataTable LoadChartData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;");


            /////////////////sql query
            string selectedItem = selectionBox.SelectedItem.ToString();
            string name = namebox.Text;
            string query = "";

            if (selectedItem == "Company")
            {
                query = $@"
                        SELECT
                            C.CompanyID,
                            C.Name,
                            TB.TB_ID,
                            TB.ProductID,
                            TB.TypeID,
                            TB.Status,
                            MONTH(TB.Transaction_Date) AS Month, -- Include the month information
                            TB.Amount
                        FROM
                            dbo.Company AS C
                        INNER JOIN
                            dbo.Transact_Buy AS TB ON C.CompanyID = TB.CompanyID
                        WHERE
                            C.Name = '{name}'";

            }
            else if (selectedItem == "Farmer")
            {
                query = $@"
                        SELECT
                            F.FarmerID,
                            F.Name,
                            TS.TS_ID,
                            TS.ProductID,
                            TS.TypeID,
                            TS.Status,
                            MONTH(TS.Transaction_Date) AS Month, -- Include the month information
                            TS.Amount
                        FROM
                            dbo.Farmer AS F
                        INNER JOIN
                            dbo.Transact_Sell AS TS ON F.FarmerID = TS.FarmerID
                        WHERE
                            F.Name = '{name}'";

            }
            //////////////////fetch and display
            DataTable dt = new DataTable();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);

            con.Close();


            // Assuming your chart control is configured with the name "dashboardChart" and has a series named "Sales"
            dashboardChart.Series.Clear(); // Clear existing series if any
            dashboardChart.Series.Add("MoneySpent"); // Add a new series
            dashboardChart.Series["MoneySpent"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Set chart type to Bar

            // Set X and Y values programmatically
            dashboardChart.Series["MoneySpent"].Points.DataBindXY(
            dt.Rows.Cast<DataRow>().Select(r => GetMonthName(Convert.ToInt32(r["Month"]))).ToArray(),
            dt.Rows.Cast<DataRow>().Select(r => Convert.ToDouble(r["Amount"])).ToArray()
            );


            dashboardChart.ChartAreas[0].AxisX.Interval = 1; // Display every month
            return dt;
        }

        private string GetMonthName(int month)
        {
            return new DateTime(2023, month, 1).ToString("MMMM");
        }

        private void dashboardChart_Load(object sender, EventArgs e)
        {
            LoadChartData();
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

        private void creditsButton_Click(object sender, EventArgs e)
        {
            transactionForm tF = new transactionForm(username);
            tF.Show();
            this.Close();
        }

        private void dashboardChart_Click(object sender, EventArgs e)
        {

        }

        private void insID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(namebox.Text))
            {
                DataTable dt = new DataTable();
                dt=LoadChartData();

                DialogResult result = MessageBox.Show("Do you want to export the report to Excel?", "Export Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ExportToExcel(dt);
                }
            }
            else
            {
                MessageBox.Show("Please select an item and enter a name before generating the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToExcel(DataTable dt)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    Title = "Save Excel File",
                    FileName = "report.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);

                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Report");
                        worksheet.Cells.LoadFromDataTable(dt, true);
                        package.Save();
                    }

                    MessageBox.Show($"Report exported successfully to {saveFileDialog.FileName}", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (selectionBox.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(namebox.Text))
            {
                DataTable dt = new DataTable();
                dt = LoadChartData();

                DialogResult result = MessageBox.Show("Do you want to export the report to Excel?", "Export Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ExportToExcel(dt);
                }
            }
            else
            {
                MessageBox.Show("Please select an item and enter a name before generating the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
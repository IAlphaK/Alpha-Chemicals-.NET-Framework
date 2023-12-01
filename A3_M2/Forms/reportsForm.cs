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
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;

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

            button1.Click += button1_Click;
            generateExcel.Click += generateExcel_Click;

        }

        private void farmersButton_MouseEnter(object sender, EventArgs e)
        {
            farmersButton.ForeColor = System.Drawing.Color.Black;
        }

        private void farmersButton_MouseLeave(object sender, EventArgs e)
        {
            farmersButton.ForeColor = System.Drawing.Color.Lime;
        }

        private void productsButton_MouseEnter(object sender, EventArgs e)
        {
            productsButton.ForeColor = System.Drawing.Color.Black;
        }

        private void productsButton_MouseLeave(object sender, EventArgs e)
        {
            productsButton.ForeColor = System.Drawing.Color.Lime;
        }

        private void creditsButton_MouseEnter(object sender, EventArgs e)
        {
            transactionsButton.ForeColor = System.Drawing.Color.Black;
        }

        private void creditsButton_MouseLeave(object sender, EventArgs e)
        {
            transactionsButton.ForeColor = System.Drawing.Color.Lime;
        }

        private void companyButton_MouseEnter(object sender, EventArgs e)
        {
            companyButton.ForeColor = System.Drawing.Color.Black;
        }

        private void companyButton_MouseLeave(object sender, EventArgs e)
        {
            companyButton.ForeColor = System.Drawing.Color.Lime;
        }

        private void reportButton_MouseEnter(object sender, EventArgs e)
        {
            reportButton.ForeColor = System.Drawing.Color.Black;
        }

        private void reportButton_MouseLeave(object sender, EventArgs e)
        {
            reportButton.ForeColor = System.Drawing.Color.Lime;
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
        private void LoadChartData()
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
                            MONTH(TB.Transaction_Date) AS Month,
                            SUM(TB.Amount) AS TotalAmount
                        FROM
                            dbo.Company AS C
                        INNER JOIN
                            dbo.Transact_Buy AS TB ON C.CompanyID = TB.CompanyID
                        WHERE
                            C.Name = '{name}'
                        GROUP BY
                            C.CompanyID,
                            C.Name,
                            MONTH(TB.Transaction_Date);";

            }
            else if (selectedItem == "Farmer")
            {
                query = $@"
                        SELECT
                            F.FarmerID,
                            F.Name,
                            MONTH(TS.Transaction_Date) AS Month,
                            SUM(TS.Amount) AS TotalAmount
                        FROM
                            dbo.Farmer AS F
                        INNER JOIN
                            dbo.Transact_Sell AS TS ON F.FarmerID = TS.FarmerID
                        WHERE
                            F.Name = '{name}'
                        GROUP BY
                            F.FarmerID,
                            F.Name,
                            MONTH(TS.Transaction_Date);";

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
            dt.Rows.Cast<DataRow>().Select(r => Convert.ToDouble(r["TotalAmount"])).ToArray()
            );



            dashboardChart.ChartAreas[0].AxisX.Interval = 1; // Display every month
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
            Dashboard dF = new Dashboard(username);
            dF.Show();
            this.Close();
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
                LoadChartData();
            }
            else
            {
                MessageBox.Show("Please select an item and enter a name before generating the report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateExcel_Click(object sender, EventArgs e)
        {
            // Assuming your DataTable is named dt
            DataTable dt = LoadDataForExcel();

            // Create a new workbook and worksheet
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet1");

            // Add DataTable headers to the worksheet
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
            }

            // Add DataTable data to the worksheet
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    object cellValue = dt.Rows[i][j];

                    // Set the value to null for reference types or use the value directly for value types
                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = cellValue.ToString();
                    }
                    else
                    {
                        worksheet.Cell(i + 2, j + 1).Value = '-';
                    }
                }
            }

            // Save the workbook to a MemoryStream
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                stream.Seek(0, SeekOrigin.Begin);

                // Save the MemoryStream to a file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx|All Files|*.*",
                    FileName = "TransactionData.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
            }

            MessageBox.Show("Excel file generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // This method fetches and returns the DataTable with the required data
        private DataTable LoadDataForExcel()
        {
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
                        TB.Transaction_Date,
                        TB.Amount
                    FROM
                        dbo.Company AS C
                    INNER JOIN
                        dbo.Transact_Buy AS TB ON C.CompanyID = TB.CompanyID
                    WHERE
                        C.Name = '{name}';";

            }
            if (selectedItem == "Farmer")
            {
                query = $@"
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
                        F.Name = '{name}';";
            }

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            return dt;
        }


    }
}
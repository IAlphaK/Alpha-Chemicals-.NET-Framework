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

namespace A3_M2
{
    public partial class Dashboard : Form
    {
        string username;
        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            usernameLabel.Text = username;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += new System.EventHandler(this.dashboardChart_Load);



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
        private void LoadChartData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;");

            DataTable dt = new DataTable();
            con.Open();

            // Modify your SQL query to extract the month and aggregate amounts
            string query = @"
                SELECT 
                    MONTH(Transaction_Date) AS Month,
                    SUM(Amount) AS TotalAmount
                    FROM dbo.Transact_Sell
                    GROUP BY MONTH(Transaction_Date)
                    ORDER BY MONTH(Transaction_Date)";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);

            con.Close();

            // Output DataTable content for debugging
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"Month: {row["Month"]}, TotalAmount: {row["TotalAmount"]}");
            }

            // Assuming your chart control is configured with the name "dashboardChart" and has a series named "Sales"
            dashboardChart.Series.Clear(); // Clear existing series if any
            dashboardChart.Series.Add("Sales"); // Add a new series
            dashboardChart.Series["Sales"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Set chart type to Bar

            // Set X and Y values programmatically
            dashboardChart.Series["Sales"].Points.DataBindXY(
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
            UpdateDashboardCounts();
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

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportsForm rF = new reportsForm(username);
            rF.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private int FetchScalarValueFromDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    // Check if result is not null and convert to int
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void UpdateDashboardCounts()
        {
            // Fetch counts from different tables
            int productCount = FetchScalarValueFromDatabase("SELECT COUNT(*) FROM Product");
            int companyCount = FetchScalarValueFromDatabase("SELECT COUNT(*) FROM Company");
            int farmerCount = FetchScalarValueFromDatabase("SELECT COUNT(*) FROM Farmer");
            int sellTransactionCount = FetchScalarValueFromDatabase("SELECT COUNT(*) FROM Transact_Sell");
            int buyTransactionCount = FetchScalarValueFromDatabase("SELECT COUNT(*) FROM Transact_Buy");

            // Calculate the total transaction count
            int totalTransactionCount = sellTransactionCount + buyTransactionCount;

            // Update the labels on the dashboard
            numOrders.Text = totalTransactionCount.ToString();
            numCompany.Text = companyCount.ToString();
            numFarmers.Text = farmerCount.ToString();
            numProducts.Text = productCount.ToString();
        }
    }
}
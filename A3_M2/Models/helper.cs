using A3_M2.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// I have helper
namespace A3_M2.Models
{
    public class helper : connection
    {
        public int FetchNextTransactionIDFromBuy()
        {
            
            string query = "SELECT ISNULL(MAX(TB_ID), 0) + 1 FROM Transact_Buy";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    // Check if result is not null and convert to int
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        public int FetchNextTransactionIDFromSell()
        {
            string query = "SELECT ISNULL(MAX(TS_ID), 0) + 1 FROM Transact_Sell";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();

                    // Check if result is not null and convert to int
                    return result != null ? Convert.ToInt32(result) : 1;
                }
            }
        }

        // Other methods and events
    }
}


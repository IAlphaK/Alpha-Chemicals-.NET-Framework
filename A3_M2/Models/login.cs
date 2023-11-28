using A3_M2.DB;
using System;
using System.Data;
using System.Data.SqlClient;

namespace A3_M2.Models
{
    internal class login : connection
    {
        public string CheckUserCredentials(string username, string password)
        {
            string result = "0";
            try
            {
                OpenConnection();

                using (SqlCommand cmd = new SqlCommand("CheckUserCredentials", _sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.Add(new SqlParameter("@p_username", SqlDbType.VarChar, 255) { Value = username });
                    cmd.Parameters.Add(new SqlParameter("@p_password", SqlDbType.VarChar, 255) { Value = password });

                    // Add output parameter
                    SqlParameter outputParameter = new SqlParameter("@p_result", SqlDbType.NVarChar, 50);
                    outputParameter.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputParameter);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameter value
                    result = outputParameter.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                result = "Error: " + ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
    }
}

using A3_M2.DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_M2.Models
{
    internal class Company : connection
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactInfo { get; set; }
        public decimal Balance { get; set; }

        // Method to delete a row by ID from the database
        public bool DeleteCompany(int companyid)
        {
            try
            {
                OpenConnection();


                // Check if there are any related transactions in Transaction_Sell
                string checkSellTransactionsQuery = "SELECT COUNT(*) FROM Transaction_Sell WHERE CompanyID = @ProductId";

                using (SqlCommand checkSellTransactionsCommand = new SqlCommand(checkSellTransactionsQuery, _sqlConnection))
                {
                    checkSellTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);

                    int sellTransactionCount = (int)checkSellTransactionsCommand.ExecuteScalar();

                    if (sellTransactionCount > 0)
                    {
                        // Delete related entries in Ledger_Farmer
                        string deleteLedgerFarmerQuery = "DELETE FROM Ledger_Farmer WHERE TS_ID IN (SELECT TS_ID FROM Transaction_Sell WHERE CompanyID = @ProductId)";

                        using (SqlCommand deleteLedgerFarmerCommand = new SqlCommand(deleteLedgerFarmerQuery, _sqlConnection))
                        {
                            deleteLedgerFarmerCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteLedgerFarmerCommand.ExecuteNonQuery();
                        }

                        // Now delete related transactions in Transaction_Sell
                        string deleteSellTransactionsQuery = "DELETE FROM Transaction_Sell WHERE CompanyID = @ProductId";

                        using (SqlCommand deleteSellTransactionsCommand = new SqlCommand(deleteSellTransactionsQuery, _sqlConnection))
                        {
                            deleteSellTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteSellTransactionsCommand.ExecuteNonQuery();
                        }
                    }
                }

                // Check if there are any related transactions in Transaction_Buy
                string checkBuyTransactionsQuery = "SELECT COUNT(*) FROM Transaction_Buy WHERE CompanyID = @ProductId";

                using (SqlCommand checkBuyTransactionsCommand = new SqlCommand(checkBuyTransactionsQuery, _sqlConnection))
                {
                    checkBuyTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);

                    int buyTransactionCount = (int)checkBuyTransactionsCommand.ExecuteScalar();

                    if (buyTransactionCount > 0)
                    {
                        // Delete related entries in Ledger_Company
                        string deleteLedgerCompanyQuery = "DELETE FROM Ledger_Company WHERE TB_ID IN (SELECT TB_ID FROM Transaction_Buy WHERE CompanyID = @ProductId)";

                        using (SqlCommand deleteLedgerCompanyCommand = new SqlCommand(deleteLedgerCompanyQuery, _sqlConnection))
                        {
                            deleteLedgerCompanyCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteLedgerCompanyCommand.ExecuteNonQuery();
                        }

                        // Now delete related transactions in Transaction_Buy
                        string deleteBuyTransactionsQuery = "DELETE FROM Transaction_Buy WHERE CompanyID = @ProductId";

                        using (SqlCommand deleteBuyTransactionsCommand = new SqlCommand(deleteBuyTransactionsQuery, _sqlConnection))
                        {
                            deleteBuyTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteBuyTransactionsCommand.ExecuteNonQuery();
                        }
                    }
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Check if there are any related transactions in Transaction_Sell
                string checkSTransactionsQuery = "SELECT COUNT(*) FROM Transact_Buy WHERE CompanyID = @ProductId";

                using (SqlCommand checkSTransactionsCommand = new SqlCommand(checkSTransactionsQuery, _sqlConnection))
                {
                    checkSTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);

                    int sTransactionCount = (int)checkSTransactionsCommand.ExecuteScalar();

                    if (sTransactionCount > 0)
                    {
                        // Delete related entries in Ledger_Farmer
                        string deleteLgerFarmerQuery = "DELETE FROM Ledger_Company WHERE TB_ID IN (SELECT TB_ID FROM Transact_Buy WHERE CompanyID = @ProductId)";

                        using (SqlCommand deleteLgerFarmerCommand = new SqlCommand(deleteLgerFarmerQuery, _sqlConnection))
                        {
                            deleteLgerFarmerCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteLgerFarmerCommand.ExecuteNonQuery();
                        }

                        // Now delete related transactions in Transaction_Sell
                        string deleteSTransactionsQuery = "DELETE FROM Transact_Buy WHERE CompanyID = @ProductId";

                        using (SqlCommand deleteSTransactionsCommand = new SqlCommand(deleteSTransactionsQuery, _sqlConnection))
                        {
                            deleteSTransactionsCommand.Parameters.AddWithValue("@ProductId", companyid);
                            deleteSTransactionsCommand.ExecuteNonQuery();
                        }
                    }
                }


                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Finally, delete the farmer
                string deleteProductQuery = "DELETE FROM Company WHERE CompanyID = @ProductId";

                using (SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, _sqlConnection))
                {
                    deleteProductCommand.Parameters.AddWithValue("@ProductId", companyid);
                    int rowsAffected = deleteProductCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting row: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Method to Insert a new Farmer
        public bool InsertCompany(int id, string farmerName, string address, string contactInfo, decimal balance)
        {
            try
            {
                OpenConnection();

                // Assuming you have a SqlCommand prepared with parameters
                using (SqlCommand command = new SqlCommand("INSERT INTO Company (CompanyID, Name, Address, ContactInfo, Balance) " +
                                                           "VALUES (@ID, @FarmerName, @Address, @ContactInfo, @Balance)", _sqlConnection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@FarmerName", farmerName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Balance", balance);

                    // Execute the SqlCommand
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insertion Completed", "Successful", MessageBoxButtons.OK);
                }

                // Return true to indicate successful insertion
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception (log, show error message, etc.)
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally { CloseConnection(); }
        }

        public Company GetCompanyByID(int companyId)
        {
            try
            {
                OpenConnection();

                // Assuming you have a SqlCommand prepared with parameters
                using (SqlCommand command = new SqlCommand("SELECT * FROM Company WHERE CompanyID = @ID", _sqlConnection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@ID", companyId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if there is data
                        if (reader.Read())
                        {
                            // Create a Farmer object with the fetched data
                            Company company = new Company
                            {
                                CompanyID = Convert.ToInt32(reader["CompanyID"]),
                                Name = Convert.ToString(reader["Name"]),
                                Address = Convert.ToString(reader["Address"]),
                                ContactInfo = Convert.ToString(reader["ContactInfo"]),
                                Balance = Convert.ToDecimal(reader["Balance"])
                            };

                            // Return the farmer
                            return company;
                        }
                    }
                }

                // If no farmer is found, return null
                return null;
            }
            catch (Exception ex)
            {
                // Handle the exception (log, show error message, etc.)
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool UpdateCompany(int id, string farmerName, string address, string contactInfo, decimal balance)
        {
            try
            {
                OpenConnection();

                // Assuming you have a SqlCommand prepared with parameters
                using (SqlCommand command = new SqlCommand("UPDATE Company " +
                                                           "SET Name = @FarmerName, " +
                                                           "    Address = @Address, " +
                                                           "    ContactInfo = @ContactInfo, " +
                "    Balance = @Balance " +
                                                           "WHERE CompanyID = @ID", _sqlConnection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@FarmerName", farmerName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Balance", balance);

                    // Execute the SqlCommand
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update Completed", "Successful", MessageBoxButtons.OK);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated. FarmerID may not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, show error message, etc.)
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
            finally { CloseConnection(); }
        }
    }
}

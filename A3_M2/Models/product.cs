using A3_M2.DB;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

internal class product : connection
{

    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string BatchNo { get; set; }
    public string Policy { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }

    // Method to delete a row by ID from the database
    public bool DeleteProduct(int productId)
    {
        try
        {
            OpenConnection();


            // Check if there are any related transactions in Transaction_Sell
            string checkSellTransactionsQuery = "SELECT COUNT(*) FROM Transaction_Sell WHERE ProductID = @ProductId";

            using (SqlCommand checkSellTransactionsCommand = new SqlCommand(checkSellTransactionsQuery, _sqlConnection))
            {
                checkSellTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);

                int sellTransactionCount = (int)checkSellTransactionsCommand.ExecuteScalar();

                if (sellTransactionCount > 0)
                {
                    // Delete related entries in Ledger_Farmer
                    string deleteLedgerFarmerQuery = "DELETE FROM Ledger_Farmer WHERE TS_ID IN (SELECT TS_ID FROM Transaction_Sell WHERE ProductID = @ProductId)";

                    using (SqlCommand deleteLedgerFarmerCommand = new SqlCommand(deleteLedgerFarmerQuery, _sqlConnection))
                    {
                        deleteLedgerFarmerCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteLedgerFarmerCommand.ExecuteNonQuery();
                    }

                    // Now delete related transactions in Transaction_Sell
                    string deleteSellTransactionsQuery = "DELETE FROM Transaction_Sell WHERE ProductID = @ProductId";

                    using (SqlCommand deleteSellTransactionsCommand = new SqlCommand(deleteSellTransactionsQuery, _sqlConnection))
                    {
                        deleteSellTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteSellTransactionsCommand.ExecuteNonQuery();
                    }
                }
            }

            // Check if there are any related transactions in Transaction_Buy
            string checkBuyTransactionsQuery = "SELECT COUNT(*) FROM Transaction_Buy WHERE ProductID = @ProductId";

            using (SqlCommand checkBuyTransactionsCommand = new SqlCommand(checkBuyTransactionsQuery, _sqlConnection))
            {
                checkBuyTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);

                int buyTransactionCount = (int)checkBuyTransactionsCommand.ExecuteScalar();

                if (buyTransactionCount > 0)
                {
                    // Delete related entries in Ledger_Company
                    string deleteLedgerCompanyQuery = "DELETE FROM Ledger_Company WHERE TB_ID IN (SELECT TB_ID FROM Transaction_Buy WHERE ProductID = @ProductId)";

                    using (SqlCommand deleteLedgerCompanyCommand = new SqlCommand(deleteLedgerCompanyQuery, _sqlConnection))
                    {
                        deleteLedgerCompanyCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteLedgerCompanyCommand.ExecuteNonQuery();
                    }

                    // Now delete related transactions in Transaction_Buy
                    string deleteBuyTransactionsQuery = "DELETE FROM Transaction_Buy WHERE ProductID = @ProductId";

                    using (SqlCommand deleteBuyTransactionsCommand = new SqlCommand(deleteBuyTransactionsQuery, _sqlConnection))
                    {
                        deleteBuyTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteBuyTransactionsCommand.ExecuteNonQuery();
                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Check if there are any related transactions in Transaction_Sell
            string checkSTransactionsQuery = "SELECT COUNT(*) FROM Transact_Sell WHERE ProductID = @ProductId";

            using (SqlCommand checkSTransactionsCommand = new SqlCommand(checkSTransactionsQuery, _sqlConnection))
            {
                checkSTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);

                int sTransactionCount = (int)checkSTransactionsCommand.ExecuteScalar();

                if (sTransactionCount > 0)
                {
                    // Delete related entries in Ledger_Farmer
                    string deleteLgerFarmerQuery = "DELETE FROM Ledger_Farmer WHERE TS_ID IN (SELECT TS_ID FROM Transact_Sell WHERE ProductID = @ProductId)";

                    using (SqlCommand deleteLgerFarmerCommand = new SqlCommand(deleteLgerFarmerQuery, _sqlConnection))
                    {
                        deleteLgerFarmerCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteLgerFarmerCommand.ExecuteNonQuery();
                    }

                    // Now delete related transactions in Transaction_Sell
                    string deleteSTransactionsQuery = "DELETE FROM Transact_Sell WHERE ProductID = @ProductId";

                    using (SqlCommand deleteSTransactionsCommand = new SqlCommand(deleteSTransactionsQuery, _sqlConnection))
                    {
                        deleteSTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteSTransactionsCommand.ExecuteNonQuery();
                    }
                }
            }

            // Check if there are any related transactions in Transaction_Buy
            string checkBTransactionsQuery = "SELECT COUNT(*) FROM Transact_Buy WHERE ProductID = @ProductId";

            using (SqlCommand checkBTransactionsCommand = new SqlCommand(checkBTransactionsQuery, _sqlConnection))
            {
                checkBTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);

                int byTransactionCount = (int)checkBTransactionsCommand.ExecuteScalar();

                if (byTransactionCount > 0)
                {
                    // Delete related entries in Ledger_Company
                    string deleteLdgerCompanyQuery = "DELETE FROM Ledger_Company WHERE TB_ID IN (SELECT TB_ID FROM Transact_Buy WHERE ProductID = @ProductId)";

                    using (SqlCommand deleteLdgerCompanyCommand = new SqlCommand(deleteLdgerCompanyQuery, _sqlConnection))
                    {
                        deleteLdgerCompanyCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteLdgerCompanyCommand.ExecuteNonQuery();
                    }

                    // Now delete related transactions in Transaction_Buy
                    string deleteByTransactionsQuery = "DELETE FROM Transact_Buy WHERE ProductID = @ProductId";

                    using (SqlCommand deleteByTransactionsCommand = new SqlCommand(deleteByTransactionsQuery, _sqlConnection))
                    {
                        deleteByTransactionsCommand.Parameters.AddWithValue("@ProductId", productId);
                        deleteByTransactionsCommand.ExecuteNonQuery();
                    }
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Finally, delete the product
            string deleteProductQuery = "DELETE FROM Product WHERE ProductID = @ProductId";

            using (SqlCommand deleteProductCommand = new SqlCommand(deleteProductQuery, _sqlConnection))
            {
                deleteProductCommand.Parameters.AddWithValue("@ProductId", productId);
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

    // Method to Insert a new Product
    public bool InsertProduct(int id, string productName, decimal price, string batchNumber, string policy, string description, int quantity, DateTime expDate)
    {
        try
        {
           
                OpenConnection();

                // Assuming you have a SqlCommand prepared with parameters
                using (SqlCommand command = new SqlCommand("INSERT INTO Product (ProductID, Name, Price, Policy, Quantity, BatchNo, ExpiryDate, Description) " +
                                                           "VALUES (@ID, @ProductName, @Price, @Policy , @Quantity, @BatchNumber, @ExpiryDate, @Description)", _sqlConnection))
                {
                    // Add parameters to the SqlCommand
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@BatchNumber", batchNumber);
                    command.Parameters.AddWithValue("@Policy", policy);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@ExpiryDate", expDate);

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
    public product GetProductByID(int productId)
    {
        try
        {
            OpenConnection();

            // Assuming you have a SqlCommand prepared with parameters
            using (SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE ProductID = @ID", _sqlConnection))
            {
                // Add parameters to the SqlCommand
                command.Parameters.AddWithValue("@ID", productId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Check if there is data
                    if (reader.Read())
                    {
                        // Create a Product object with the fetched data
                        product product = new product
                        {
                            ProductID = Convert.ToInt32(reader["ProductID"]),
                            Name = Convert.ToString(reader["Name"]),
                            Price = Convert.ToDecimal(reader["Price"]),
                            BatchNo = Convert.ToString(reader["BatchNo"]),
                            Policy = Convert.ToString(reader["Policy"]),
                            Description = Convert.ToString(reader["Description"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"])
                        };

                        // Return the product
                        return product;
                    }
                }
            }

            // If no product is found, return null
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

    public bool UpdateProduct(int id, string productName, decimal price, string batchNumber, string policy, string description, int quantity, DateTime expDate)
    {
        try
        {
            OpenConnection();

            // Assuming you have a SqlCommand prepared with parameters
            using (SqlCommand command = new SqlCommand("UPDATE Product " +
                                                       "SET Name = @ProductName, " +
                                                       "    Price = @Price, " +
                                                       "    BatchNo = @BatchNumber, " +
                                                       "    Policy = @Policy, " +
                                                       "    Description = @Description, " +
                                                       "    Quantity = @Quantity, " +
                                                       "    ExpiryDate = @ExpiryDate " +
                                                       "WHERE ProductID = @ID", _sqlConnection))
            {
                // Add parameters to the SqlCommand
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@BatchNumber", batchNumber);
                command.Parameters.AddWithValue("@Policy", policy);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@ExpiryDate", expDate);

                // Execute the SqlCommand
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update Completed", "Successful", MessageBoxButtons.OK);
                    return true;
                }
                else
                {
                    MessageBox.Show("No rows were updated. ProductID may not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

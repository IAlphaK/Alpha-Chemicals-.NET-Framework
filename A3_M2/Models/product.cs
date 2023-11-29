using A3_M2.DB;
using System.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Windows.Forms;

internal class product : connection
{
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
}

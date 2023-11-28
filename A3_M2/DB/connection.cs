using System;
using System.Data.SqlClient;

namespace A3_M2.DB
{
    public class connection
    {
        private readonly string connectionString;

        public connection() : this(
            @"Data Source=.; Initial Catalog=alpha_chemicals; Integrated Security=True;")
        {
        }

        //public connection() : this(
        //    @"Data Source=DESKTOP-3UKGS5J\MSSQLSERVER01; Initial Catalog=alpha_chemicals; Integrated Security=True;"
        //    )
        //{
        //}

        public connection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal SqlConnection _sqlConnection = null;

        public void OpenConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            builder.TrustServerCertificate = true;

            _sqlConnection = new SqlConnection(builder.ConnectionString);
            _sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (_sqlConnection?.State != System.Data.ConnectionState.Closed)
            {
                _sqlConnection?.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides the information for the database connection
    /// </summary>
    public static class DBConnection
    {
        /// <summary>
        /// Gets the database connection
        /// </summary>
        /// <returns>Connection to TechSupport database</returns>
        public static SqlConnection GetConnection()
        {
            try
            {
                string connectionString =
                    "Data Source=localhost;Initial Catalog=Payables;" +
                    "Integrated Security=True;";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            }
    }
}

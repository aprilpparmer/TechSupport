using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TechSupport.Model;
using TechSupport.Controller;

namespace TechSupport.DAL
{
    /// <summary>
    /// Gets information from the Customers database
    /// </summary>
    class CustomersDAL
    {
        /// <summary>
        /// Gets all customer names from the database
        /// </summary>
        /// <returns></returns>
        public static List<Customers> GetAllCustomers()
        {
            List<Customers> customerList = new List<Customers>();
            SqlConnection connection = DBConnection.GetConnection();
            string selectStatement =
                "SELECT Name FROM Customers ORDER BY Name ASC ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Customers customer = new Customers();
                    customer.CustomerName = reader["Name"].ToString();
                    customerList.Add(customer);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customerList;
        }
    }
}

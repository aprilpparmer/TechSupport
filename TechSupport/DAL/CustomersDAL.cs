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
            string selectStatement =
                    "SELECT Name FROM Customers ORDER BY Name ASC ";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Customers customer = new Customers();
                                customer.CustomerName = reader["Name"].ToString();
                                customerList.Add(customer);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return customerList;
          }
     }
}

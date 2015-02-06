using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Gets information from the Products database
    /// </summary>
    class ProductsDAL
    {
        /// <summary>
        /// Gets all of the product names from the database
        /// </summary>
        /// <returns>List of product names</returns>
        public static List<Products> GetAllProducts()
        {
            List<Products> productList = new List<Products>();
            SqlConnection connection = DBConnection.GetConnection();
            string selectStatement =
                "SELECT Name FROM Products ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Products product = new Products();
                    product.ProductName = reader["Name"].ToString();
                    productList.Add(product);
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
            return productList;
        }
    }
}

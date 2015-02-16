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
            string selectStatement = "SELECT Name FROM Products ";
            try {
                using (SqlConnection connection = DBConnection.GetConnection())
                { 
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Products product = new Products();
                                product.ProductName = reader["Name"].ToString();
                                productList.Add(product);
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
            return productList;
        }
    }
}

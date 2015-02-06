using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Interacts with the ProductsDAL to deliver information to the view.
    /// </summary>
    class ProductsController
    {
        public ProductsController() {}

        /// <summary>
        /// Gets all of the product names in the database.
        /// </summary>
        /// <returns>List of all product names</returns>
        public List<Products> GetAllProducts()
        {
            return ProductsDAL.GetAllProducts();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class ProductsController
    {
        public ProductsController() {}

        public List<Products> GetAllProducts()
        {
            return ProductsDAL.GetAllProducts();
        }
    }
}

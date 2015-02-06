using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Gets and sets all appropriate values for the Products class
    /// </summary>
    class Products
    {
        private string productName;

        public Products() {}

        public string ProductName
        {
            get 
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DAL;

namespace TechSupport.Controller
{
    /// <summary>
    /// Interacts with the CustomersDAL to deliver data to the view.
    /// </summary>
    class CustomersController
    {
        public CustomersController() {}

        /// <summary>
        /// Gets all of the customer names from the database
        /// </summary>
        /// <returns>List of customer names</returns>
        public List<Customers> GetAllCustomers()
        {
            return CustomersDAL.GetAllCustomers();
        }
    }
}

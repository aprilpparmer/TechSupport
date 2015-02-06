using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Customers
    {
        private string customerName;

        public Customers() {}

        public string CustomerName
        {
            get 
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
    }
}

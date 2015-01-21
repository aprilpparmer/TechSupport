using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incidents
    {
        private string productCode;
        private DateTime dateOpened;
        private string customer;
        private string technician;
        private string title; 
        private int? techID;
        
        public Incidents() {}

        public string ProductCode
        {
            get
            {
                return productCode;
            }
            set
            {
                productCode = value;
            }
        }

        public DateTime DateOpened 
        {
            get
            {
                return dateOpened;
            }
            set
            {
                dateOpened = value;
            }
        }

        public string Customer
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
            }
        }

        public string Technician
        {
            get
            {
                return technician;
            }
            set
            {
                technician = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
    }
}

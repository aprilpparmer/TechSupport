using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Gets and sets all of the appropriate values of the Incidents class
    /// </summary>
    public class Incidents
    {
        private string customerName;
        private string technician;
        private string productName;
        private string productCode;
        private DateTime dateOpened;
        private int customerID;
        private string title;
        private string description;
        private int incidentID;
        private int? techID;
        private DateTime dateClosed;
        public Incidents() {}

        public DateTime DateClosed
        {
            get
            {
                return dateClosed;
            }
            set
            {
                dateClosed = value;
            }
        }
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

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

        public int? TechID
        {
            get
            {
                return techID;
            }
            set
            {
                techID = value;
            }
        }

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

        public int IncidentID
        {
            get
            {
                return incidentID;
            }
            set
            {
                incidentID = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
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

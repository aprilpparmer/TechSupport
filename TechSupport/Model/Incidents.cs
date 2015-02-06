using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class Incidents
    {
        private string productName;
        private DateTime dateOpened;
        private string customerName;
        private string technician;
        private string title;
        private string description;
        private int incidentID;
        
        public Incidents() {}

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

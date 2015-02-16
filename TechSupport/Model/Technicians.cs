using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Technicians
    {
        private string technicianName;
        private int techID;

        public Technicians() {}

        /// <summary>
        /// Gets and Sets the TechID
        /// </summary>
        public int TechID
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

        /// <summary>
        /// Gets and Sets the Technician Name
        /// </summary>
        public string TechnicianName
        {
            get 
            {
                return technicianName;
            }
            set
            {
                technicianName = value;
            }
        }
    }
}

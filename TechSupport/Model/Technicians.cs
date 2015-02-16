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

        public Technicians() {}

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

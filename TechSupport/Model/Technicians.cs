using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Technicians
    {
        private string technician;
        private int techID;
        public Technicians() { }
    
        public String Technician
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
    
    
    }
}

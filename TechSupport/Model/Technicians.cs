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
        private string techEmail;
        private string techPhone;
        public Technicians() { }

        public String TechEmail
        {
            get
            {
                return techEmail;
            }
            set
            {
                techEmail = value;
            }
        }

        public String TechPhone
        {
            get
            {
                return techPhone;
            }
            set
            {
                techPhone = value;
            }
        }

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

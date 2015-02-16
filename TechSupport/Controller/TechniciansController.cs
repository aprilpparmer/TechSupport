using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Interacts with the TechniciansDAL to deliver data to the view.
    /// </summary>
    class TechniciansController
    {
        /// <summary>
        /// Gets all of the technician names from the database
        /// </summary>
        /// <returns>List of technician names</returns>
        public List<Technicians> GetAllTechnicians()
        {
            return TechniciansDAL.GetAllTechnicians();
        }
    }
}

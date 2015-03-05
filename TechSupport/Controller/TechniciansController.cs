using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class TechniciansController
    {
        /// <summary>
        /// Gets the list of technicians
        /// </summary>
        /// <returns></returns>
        public static List<Technicians> GetTechniciansList()
        {
            return TechniciansDAL.GetTechniciansList();
        }

        /// <summary>
        /// Gets the list of technicians who have incidents
        /// </summary>
        /// <returns></returns>
        public static List<Technicians> GetTechniciansWithIncidents()
        {
            return TechniciansDAL.GetTechniciansWithIncidents();
        }

        /// <summary>
        /// Gets the information for the selected technician
        /// </summary>
        /// <param name="techID"></param>
        /// <returns></returns>
        public static Technicians GetTechnicianData(int techID)
        {
            return TechniciansDAL.GetTechnicianData(techID);
        }
    }
}

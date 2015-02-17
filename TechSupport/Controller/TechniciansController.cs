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
    }
}

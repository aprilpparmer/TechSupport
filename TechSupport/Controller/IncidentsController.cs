using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DAL;

namespace TechSupport.Controller
{
    /// <summary>
    /// Interacts with the IncidentsDAL to deliver information to the view
    /// </summary>
    class IncidentsController
    {
        public IncidentsController()
        {
        }

        /// <summary>
        /// Calls the DisplayOpenIncidents method of the IncidentsDAL class
        /// to display all open incidents in the database.
        /// </summary>
        /// <returns>List of open incidents</returns>
        public List<Incidents> DisplayOpenIncidents()
        {
            return IncidentsDAL.DisplayOpenIncidents();
        }

        /// <summary>
        /// Calls the AddIncident method of the IncidentsDAL class 
        /// to add a new incident to the database
        /// </summary>
        /// <param name="incident">Incident to add to the database</param>
        /// <returns>IncidentID of the new Incident</returns>
        public static int AddIncident(Incidents incident)
        {
            return IncidentsDAL.AddIncident(incident);
        }
    }
}

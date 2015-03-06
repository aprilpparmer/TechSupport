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

        /// <summary>
        /// Calls the GetIncident method of the IncidentsDAL class
        /// to get all of the Incident's information
        /// </summary>
        /// <param name="incidentID">IncidentID of the referred to Incident</param>
        /// <returns>The Incident Information</returns>
        public static Incidents GetIncident(int incidentID)
        {
            return IncidentsDAL.GetIncident(incidentID);
        }

        /// <summary>
        /// Calls the UpdateIncident method of the IncidentsDAL class
        /// to update the Incident's information
        /// </summary>
        /// <param name="oldIncident">Old Incident Information</param>
        /// <param name="newIncident">New Incident Information</param>
        /// <returns></returns>
        public static bool UpdateIncident(Incidents oldIncident, Incidents newIncident)
        {
            return IncidentsDAL.UpdateIncident(oldIncident, newIncident);
        }

        /// <summary>
        /// Calls the CloseIncident method of the IncidentsDAL class
        /// to change the CloseDate of an Incident
        /// </summary>
        /// <param name="incidentID">IncidentID of the Incident to Close</param>
        /// <returns></returns>
        public static bool CloseIncident(int incidentID)
        {
            return IncidentsDAL.CloseIncident(incidentID);
        }

        public static List<Incidents> GetTechnicianIncidents(int techID)
        {
            return IncidentsDAL.GetTechnicianIncidents(techID);
        }
    }
}

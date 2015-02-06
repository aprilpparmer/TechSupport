using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DAL;

namespace TechSupport.Controller
{
    //Interacts with the DAL
    class IncidentsController
    {
        public IncidentsController()
        {
        }

        //Calls the DisplayOpenIncidents method of the IncidentsDAL class
        //to display all open incidents in the database.
        public List<Incidents> DisplayOpenIncidents()
        {
            return IncidentsDAL.DisplayOpenIncidents();
        }
    }
}

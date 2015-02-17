using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class TechniciansDAL
    {
        public static List<Technicians> GetTechniciansList() 
        {
            List<Technicians> techniciansList = new List<Technicians>();
            string selectStatement =
                "SELECT TechID, Name FROM Technicians";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection()) 
                {
                    connection.Open();   
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                        {
                            using (SqlDataReader reader = selectCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Technicians technician = new Technicians();
                                    technician.Technician = reader["Name"].ToString();
                                    technician.TechID = (int)reader["TechID"];
                                    techniciansList.Add(technician);
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return techniciansList;
        }

    }
}

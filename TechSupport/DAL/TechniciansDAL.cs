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
        /// <summary>
        /// Gets a list of technicians from the database
        /// </summary>
        /// <returns>technician list</returns>
        public static List<Technicians> GetTechniciansList() 
        {
            List<Technicians> techniciansList = new List<Technicians>();
            string selectStatement =
                "SELECT * FROM Technicians";
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
                                    technician.TechEmail = reader["Email"].ToString();
                                    technician.TechPhone = reader["Phone"].ToString();
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

        /// <summary>
        /// Gets the data for a specific technician
        /// </summary>
        /// <param name="techID"></param>
        /// <returns></returns>
        public static Technicians GetTechnicianData(int techID)
        {
            Technicians technician = new Technicians();
            string selectStatement =
                "SELECT * FROM Technicians " +   
                "WHERE TechID = @TechID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@TechID", techID);
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                technician.Technician = reader["Name"].ToString();
                                technician.TechID = (int)reader["TechID"];
                                technician.TechEmail = reader["Email"].ToString();
                                technician.TechPhone = reader["Phone"].ToString();
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
            return technician;
        }

        /// <summary>
        /// Gets technicians with open incidents
        /// </summary>
        /// <returns>technician list</returns>
        public static List<Technicians> GetTechniciansWithIncidents()
        {
            List<Technicians> techniciansList = new List<Technicians>();
            string selectStatement =
                "SELECT * FROM Technicians " +   
                "WHERE TechID = (SELECT DISTINCT TechID FROM Incidents " + 
	                "WHERE Technicians.TechID = Incidents.TechID AND DateClosed IS NULL) " +
                "ORDER BY Name";
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
                                technician.TechEmail = reader["Email"].ToString();
                                technician.TechPhone = reader["Phone"].ToString();
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

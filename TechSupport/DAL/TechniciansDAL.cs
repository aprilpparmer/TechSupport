using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Gets information from the Technicians database
    /// </summary>
    class TechniciansDAL
    {
        /// <summary>
        /// Gets all technician names from the database
        /// </summary>
        /// <returns></returns>
        public static List<Technicians> GetAllTechnicians()
        {
            List<Technicians> technicianList = new List<Technicians>();                
            string selectStatement =
                "SELECT Name FROM Technicians ORDER BY Name ASC ";
            try {
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
                                technician.TechnicianName = reader["Name"].ToString();
                                technicianList.Add(technician);
                            }
                        }
                    }
                }
                return technicianList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Gets the techID of the technician
        /// </summary>
        /// <param name="techName"></param>
        /// <returns></returns>
        public static int GetTechID(String techName)
        {
            Technicians technician = new Technicians();
            string selectStatement =
                "SELECT TechID FROM Technicians WHERE Name = @techName";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@techName", techName);
                        int techID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return techID;
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
        }
    }
}

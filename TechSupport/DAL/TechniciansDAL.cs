using System;
using System.Collections.Generic;
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
            try
            {
                List<Technicians> technicianList = new List<Technicians>();
                SqlConnection connection = DBConnection.GetConnection();
                string selectStatement =
                    "SELECT Name FROM Technicians ORDER BY Name ASC ";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Technicians technician = new Technicians();
                        technician.TechnicianName = reader["Name"].ToString();
                        technicianList.Add(technician);
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
                return technicianList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

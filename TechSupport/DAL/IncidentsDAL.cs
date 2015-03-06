using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;
using System.Data;
using TechSupport.Controller;

namespace TechSupport.DAL
{
    /// <summary>
    /// Gets information from the Incidents database
    /// </summary>
    class IncidentsDAL
    {
        /// <summary>
        /// Gets all open incidents in the database
        /// </summary>
        /// <returns></returns>
        public static List<Incidents> DisplayOpenIncidents()
        {
            List<Incidents> openIncidentsList = new List<Incidents>();
            string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, i.Title, " +
                "c.Name AS Customer, t.Name AS Technician " +
                "FROM Incidents i " +
                    "LEFT OUTER JOIN Technicians t ON t.TechID = i.TechID " +
                    "LEFT OUTER JOIN Customers c ON c.CustomerID = i.CustomerID " +
                "WHERE i.DateClosed IS NULL " +
                    "ORDER BY i.DateOpened";
                
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
                                    Incidents incident = new Incidents();
                                    incident.ProductCode = reader["ProductCode"].ToString();
                                    incident.DateOpened = (DateTime)reader["DateOpened"];
                                    incident.CustomerName = reader["Customer"].ToString();
                                    incident.Technician = reader["Technician"].ToString();
                                    incident.Title = reader["Title"].ToString();
                                    openIncidentsList.Add(incident);
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
                return openIncidentsList;
        }

        /// <summary>
        /// Adds a new Incident to the database
        /// </summary>
        /// <param name="incident">Incident to add to the database</param>
        /// <returns>IncidentID of the new Incident</returns>
        public static int AddIncident(Incidents incident) 
        {
            string insertStatement =
                "INSERT INTO Incidents " +
                    "(CustomerID, ProductCode, DateOpened, Title, Description) " +
                    "VALUES (@CustomerID, @ProductCode, @DateOpened, @Title, @Description)";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@CustomerID", incident.CustomerID);
                        insertCommand.Parameters.AddWithValue("@ProductCode", incident.ProductCode);
                        insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
                        insertCommand.Parameters.AddWithValue("@Title", incident.Title);
                        insertCommand.Parameters.AddWithValue("@Description", incident.Description);

                        connection.Open();
                        insertCommand.ExecuteNonQuery();
                        string selectStatement =
                            "SELECT IDENT_CURRENT('Incidents') FROM Incidents";
                        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                        int incidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return incidentID;
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

        /// <summary>
        /// Gets a specific Incident from the database
        /// </summary>
        /// <param name="incidentID"></param>
        /// <returns></returns>
        public static Incidents GetIncident(int incidentID)
        {
            Incidents incident = new Incidents();
            
            string selectStatement =
                "SELECT i.IncidentID, c.Name AS Customer, p.Name AS Product, " + 
                "t.Name AS Technician, t.TechID, " +
		        "i.Title, i.DateOpened, i.Description, i.DateClosed " +
                "FROM Incidents i " +	
	            "LEFT OUTER JOIN Technicians t ON t.TechID = i.TechID " +
	            "JOIN Customers c ON c.CustomerID = i.CustomerID " +
            	"JOIN Products p ON p.ProductCode = i.ProductCode " +
                "WHERE IncidentID = @IncidentID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);
                        using (SqlDataReader reader =
                            selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            
                            if (reader.Read())
                            {
                                incident.IncidentID = (int)reader["IncidentID"];
                                incident.CustomerName = reader["Customer"].ToString();
                                incident.ProductName = reader["Product"].ToString();
                                incident.Technician = reader["Technician"].ToString();
                                incident.Title = reader["Title"].ToString();
                                incident.DateOpened = (DateTime)reader["DateOpened"];
                                incident.Description = reader["Description"].ToString();
                                if (reader["DateClosed"] != DBNull.Value)
                                {
                                    incident.DateClosed = (DateTime)reader["DateClosed"];
                                }
                                if (reader["TechID"] != DBNull.Value)
                                {
                                    incident.TechID = Convert.ToInt32(reader["TechID"]);
                                }
                                else
                                {
                                    incident.TechID = null;
                                }
                            }
                            else
                            {
                                incident = null;
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
            return incident;
        }

        /// <summary>
        /// Updates an Incident's Technician and/or Description
        /// </summary>
        /// <param name="oldIncident">The original incident information</param>
        /// <param name="newIncident">The new incident information</param>
        /// <returns>true if updated properly</returns>
        public static bool UpdateIncident(Incidents oldIncident, Incidents newIncident)
        {
            string updateStatement = 
                "UPDATE Incidents SET " +
                  "TechID = @NewTechID, " +
                  "Description = @NewDescription " +
                "WHERE IncidentID = @OldIncidentID " +
                "AND (TechID = @OldTechID " +
                    "OR TechID IS NULL AND @OldTechID IS NULL) " +
                "AND Description = @OldDescription";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        if (oldIncident.TechID == null)
                            updateCommand.Parameters.AddWithValue("@OldTechID", DBNull.Value);
                        else 
                            updateCommand.Parameters.AddWithValue("@OldTechID", oldIncident.TechID);
                        if (newIncident.TechID == null)
                            updateCommand.Parameters.AddWithValue("@NewTechID", DBNull.Value);
                        else
                            updateCommand.Parameters.AddWithValue("@NewTechID", newIncident.TechID);

                        updateCommand.Parameters.AddWithValue("@NewDescription", newIncident.Description);
                        updateCommand.Parameters.AddWithValue("@OldIncidentID", oldIncident.IncidentID);
                        updateCommand.Parameters.AddWithValue("@OldDescription", oldIncident.Description);

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
                            return true;
                        else
                            return false;
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

        /// <summary>
        /// Updates the DateClosed for the incident
        /// </summary>
        /// <param name="incidentID">IncidentID used to select appropriate incident</param>
        /// <returns>true is updated properly</returns>
        public static bool CloseIncident(int incidentID)
        {
            string updateStatement =
                "UPDATE Incidents SET " +
                "DateClosed = @NewDateClosed " +
                "WHERE IncidentID = @incidentID";
            try
            {
                using (SqlConnection connection = DBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewDateClosed", DateTime.Now);
                        updateCommand.Parameters.AddWithValue("@incidentID", incidentID);
                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0)
                            return true;
                        else
                            return false;
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

        /// <summary>
        /// Gets a list of incidents for the specified technicians
        /// </summary>
        /// <param name="techID"></param>
        /// <returns></returns>
        public static List<Incidents> GetTechnicianIncidents(int techID)
        {
            List<Incidents> technicianIncidentsList = new List<Incidents>();
            string selectStatement =
                "SELECT i.TechID, p.Name AS ProductName, i.DateOpened, " +
                    "i.DateClosed, c.Name AS CustomerName, i.Title " +
                "FROM Incidents i " +
                    "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                    "JOIN Products p ON i.ProductCode = p.ProductCode " +
                "WHERE i.TechID = @TechID AND i.DateClosed IS NULL";
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
                                Incidents incident = new Incidents();
                                incident.ProductName = reader["ProductName"].ToString();
                                incident.DateOpened = (DateTime)reader["DateOpened"];
                                incident.CustomerName = reader["CustomerName"].ToString();
                                incident.Title = reader["Title"].ToString();
                                technicianIncidentsList.Add(incident);
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
            return technicianIncidentsList;
        }  
    }
}

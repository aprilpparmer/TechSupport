using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;
using System.Data;

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
            try
            {
                List<Incidents> openIncidentsList = new List<Incidents>();
                SqlConnection connection = DBConnection.GetConnection();
                string selectStatement =
                    "SELECT i.ProductCode, i.DateOpened, i.Title, " +
                    "c.Name AS Customer, t.Name AS Technician " +
                    "FROM Incidents i " +
                        "LEFT OUTER JOIN Technicians t ON t.TechID = i.TechID " +
                        "LEFT OUTER JOIN Customers c ON c.CustomerID = i.CustomerID " +
                    "WHERE i.DateClosed IS NULL " +
                    "ORDER BY i.DateOpened";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
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
                return openIncidentsList;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adds a new Incident to the database
        /// </summary>
        /// <param name="incident">Incident to add to the database</param>
        /// <returns>IncidentID of the new Incident</returns>
        public static int AddIncident(Incidents incident) {
            try
            {
                SqlConnection connection = DBConnection.GetConnection();
                string insertStatement =
                    "INSERT INTO Incidents " +
                        "(CustomerID, ProductCode, DateOpened, Title, Description) " +
                        "VALUES ((SELECT CustomerID FROM Customers WHERE Name = @CustomerName), " +
                        "(SELECT ProductCode FROM Products WHERE Name = @ProductName), " +
                        "@DateOpened, @Title, @Description)";
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@CustomerName", incident.CustomerName);
                insertCommand.Parameters.AddWithValue("@ProductName", incident.ProductName);
                insertCommand.Parameters.AddWithValue("@DateOpened", incident.DateOpened);
                insertCommand.Parameters.AddWithValue("@Title", incident.Title);
                insertCommand.Parameters.AddWithValue("@Description", incident.Description);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    string selectStatement =
                        "SELECT IDENT_CURRENT('Incidents') FROM Incidents";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    int incidentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return incidentID;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public static Incidents GetIncident(int incidentID)
        {
            Incidents incident = new Incidents();
            SqlConnection connection = DBConnection.GetConnection();
            string selectStatement =
                "SELECT i.IncidentID, c.Name AS Customer, p.Name AS Product, " + 
                "t.Name AS Technician, " +
		        "i.Title, i.DateOpened, i.Description " +
                "FROM Incidents i " +	
	            "LEFT OUTER JOIN Technicians t ON t.TechID = i.TechID " +
	            "JOIN Customers c ON c.CustomerID = i.CustomerID " +
            	"JOIN Products p ON p.ProductCode = i.ProductCode " +
                "WHERE IncidentID = @IncidentID";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@IncidentID", incidentID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    incident.IncidentID = (int)reader["IncidentID"];
                    incident.CustomerName = reader["Customer"].ToString();
                    incident.ProductName = reader["Product"].ToString();
                    incident.Technician = reader["Technician"].ToString();
                    incident.Title = reader["Title"].ToString();
                    incident.DateOpened = (DateTime)reader["DateOpened"];
                    incident.Description = reader["Description"].ToString();
                }
                else
                {
                    incident = null;
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
            return incident;
        }
    }
}

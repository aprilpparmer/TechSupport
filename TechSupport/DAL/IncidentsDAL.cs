using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    class IncidentsDAL
    {
        //Displays all open incidents
        public static List<Incidents> DisplayOpenIncidents()
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
                    incident.Customer = reader["Customer"].ToString();
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

        //Adds an incident to the database
        public static int AddIncident(Incidents incident) {
            SqlConnection connection = DBConnection.GetConnection();
            string insertStatement =
                "INSERT INTO Incidents " +
                    "(CustomerID, ProductCode, DateOpened, Title, Description) " +
                    "VALUES ((SELECT CustomerID FROM Customers WHERE Name = @CustomerName), " +
                    "(SELECT ProductCode FROM Products WHERE Name = @ProductName), " + 
                    "@DateOpened, @Title, @Description ";
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


        }
    }
}

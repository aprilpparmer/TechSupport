using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Model;
using TechSupport.Controller;
using System.Data.SqlClient;


namespace TechSupport.View
{
    /// <summary>
    /// Creates a form used to add a new incident to the database
    /// </summary>
    public partial class CreateIncidentForm : Form
    {
        private Incidents incident;

        public CreateIncidentForm()
        {
                InitializeComponent();
        }

        /// <summary>
        /// When clicked, a new incident is created in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createIncidentBtn_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                    incident = new Incidents();
                    this.PutIncidentData(incident);
                    try
                    {
                        incident.IncidentID = IncidentsController.AddIncident(incident);
                        MessageBox.Show("You have successfully added a new incident.");
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
            }
        }

        /// <summary>
        /// Sets the data in the form to an Incident object to be added to the database
        /// </summary>
        /// <param name="incident"></param>
        private void PutIncidentData(Incidents incident)
        {
            incident.CustomerID = (int)customerComboBox.SelectedValue;
            incident.ProductCode = productComboBox.SelectedValue.ToString();
            incident.DateOpened = DateTime.Now;
            incident.Title = titleTextBox.Text;
            incident.Description = descriptionTextBox.Text;
        }

        /// <summary>
        /// Checks if any fields are left blank
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(customerComboBox) &&
                Validator.IsPresent(productComboBox) &&
                Validator.IsPresent(titleTextBox) &&
                Validator.IsPresent(descriptionTextBox))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateIncidentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupportDataSet1.Products);
            // TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);

        }
    }
}

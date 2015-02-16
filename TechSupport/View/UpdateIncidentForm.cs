using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class UpdateIncidentForm : Form
    {

        private TechniciansController techController;
        private Incidents incident;

        public UpdateIncidentForm()
        {
            InitializeComponent();
            this.techController = new TechniciansController();
            this.loadTechnicianNames();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When clicked, displays the Incident
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getIncidentButton_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtIncidentID) &&
                Validator.IsInt32(txtIncidentID))
            {
                int incidentID = Convert.ToInt32(txtIncidentID.Text);
                this.GetIncident(incidentID);
            }
        }

        private void GetIncident(int incidentID)
        {
            try
            {
                incident = IncidentsController.GetIncident(incidentID);
                if (incident == null)
                    MessageBox.Show("No incident found with this ID." +
                        "Please try again.", "Incident Not Found");
                else
                    this.DisplayIncident();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayIncident()
        {
            txtCustomer.Text = incident.CustomerName;
            txtProduct.Text = incident.ProductName;
            technicianComboBox.Enabled = true;
            if (incident.Technician != null)
            {
                technicianComboBox.SelectedItem = incident.Technician;
            }
            else technicianComboBox.SelectedIndex = -1;
            txtTitle.Text = incident.Title;
            txtDateOpened.Text = incident.DateOpened.ToString("d");
            txtDescription.Text = incident.Description;
            txtToAdd.Enabled = true;
            txtToAdd.ReadOnly = false;
            updateIncidentButton.Enabled = true;
            closeIncidentButton.Enabled = true;

        }

        /// <summary>
        /// Loads the technician names into a combo box
        /// </summary>
        private void loadTechnicianNames()
        {
            List<Technicians> technicianList;
            try
            {
                technicianList = this.techController.GetAllTechnicians();
                if (technicianList.Count > 0)
                {
                    Technicians technician;
                    for (int i = 0; i < technicianList.Count; i++)
                    {
                        technician = technicianList[i];
                        technicianComboBox.Items.Add(technician.TechnicianName);
                    }
                }
                else
                {
                    MessageBox.Show("There are no technician names to display.");
                    this.Close();
                }
                technicianComboBox.SelectedIndex = -1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}

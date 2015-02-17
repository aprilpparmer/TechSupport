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
        private Incidents incident;
        private Incidents newIncident;
        private List<Technicians> techList;

        public UpdateIncidentForm()
        {
            InitializeComponent();
            incident = new Incidents();
            newIncident = new Incidents();
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
            technicianComboBox.Enabled = true;
            this.LoadTechComboBox(); ;
            if (incident.TechID == null)
            {
                technicianComboBox.SelectedIndex = -1;
            }
            else
            {
                technicianComboBox.SelectedText = incident.Technician;
            }
            txtCustomer.Text = incident.CustomerName;
            txtProduct.Text = incident.ProductName;
            txtTitle.Text = incident.Title;
            txtDateOpened.Text = incident.DateOpened.ToString("d");
            txtDescription.Text = incident.Description;
            txtToAdd.Enabled = true;
            txtToAdd.ReadOnly = false;
            updateIncidentButton.Enabled = true;
            closeIncidentButton.Enabled = true;

        }

        /// <summary>
        /// Updates the incident with new information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateIncidentButton_Click(object sender, EventArgs e)
        {   
            newIncident = incident;
            try
                {
                    this.PutIncidentData(newIncident);
                    if (newIncident.Description.Length > 200)
                    {
                        MessageBox.Show("Only 200 characters are allowed for a description.");
                    }
                    else
                    {
                        bool updated = IncidentsController.UpdateIncident(incident, newIncident);
                        if (updated)
                        {
                            MessageBox.Show("You have successfully updated the incident.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("The incident could not be updated at ths time");
                        }
                    }
                }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Sets the data in the form to an Incident object to be updated in the database
        /// </summary>
        /// <param name="incident"></param>
        private void PutIncidentData(Incidents incident)
        {
            try
            {
                if (technicianComboBox.SelectedIndex > -1)
                {
                    incident.TechID = (int)technicianComboBox.SelectedValue;
                }

                if (txtToAdd.Text == "")
                {
                    txtToAdd.Text = "Technician was updated.";
                }
                incident.Description = txtDescription.Text + Environment.NewLine +
                    "<" + DateTime.Now.ToString("d") + "> " + txtToAdd.Text;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Closes the UpdateIncidentForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool updated;
                if (incident.DateClosed == DateTime.MinValue)
                {
                    updated = IncidentsController.CloseIncident(incident.IncidentID);
                    if (updated)
                    {
                        MessageBox.Show("You have successfully closed the incident.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("The incident could not be closed at ths time");
                    } 
                }
                else
                {
                    MessageBox.Show("The incident has already been closed. " + incident.DateClosed.ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Loads the technician combo box
        /// </summary>
        private void LoadTechComboBox()
        {
            try
            {
                techList = TechniciansController.GetTechniciansList();
                technicianComboBox.DataSource = techList;
                technicianComboBox.DisplayMember = "Technician";
                technicianComboBox.ValueMember = "TechID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}

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
    /// <summary>
    /// Creates a form used to update or close an incident in the database.
    /// </summary>
    public partial class UpdateIncidentForm : Form
    {
        private Incidents incident;
        private List<Technicians> techList;

        public UpdateIncidentForm()
        {
            InitializeComponent();
            incident = new Incidents();
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
        /// <summary>
        /// Populates the form with an incident's information
        /// </summary>
        /// <param name="incidentID">incidentID of the specified incident</param>
        private void GetIncident(int incidentID)
        {
            try
            {
                incident = IncidentsController.GetIncident(incidentID);
                if (incident == null)
                {
                   // this.ClearBoxes();
                    MessageBox.Show("No incident found with this ID. " +
                        "Please try again.", "Incident Not Found");
                } 
                else if (incident.DateClosed != DateTime.MinValue)
                {
                    //this.ClearBoxes();
                    MessageBox.Show("This incident is closed. Please enter " +
                        "another Incident ID");
                }
                else
                    this.DisplayIncident();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Displays the information for the incident
        /// </summary>
        private void DisplayIncident()
        {
           
            this.LoadTechComboBox(); ;
            if (incident.TechID == null)
            {
                technicianComboBox.SelectedIndex = -1;
            }
            else
            {
                technicianComboBox.SelectedValue = incident.TechID;
            } 
            technicianComboBox.Enabled = true;
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
        /*
        /// <summary>
        /// Updates the incident with new information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateIncidentButton_Click(object sender, EventArgs e)
        {
            Incidents newIncident = new Incidents();
            newIncident.IncidentID = incident.IncidentID;
            this.PutIncidentData(newIncident);
            try
                {
                    if (!IncidentsController.UpdateIncident(incident, newIncident))
                    {
                        MessageBox.Show("Another user has updated or " +
                            "deleted that incident.", "Database Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        incident = newIncident;
                        this.DialogResult = DialogResult.OK;
                    }

                /**
                this.PutIncidentData(newIncident);
                bool updated = IncidentsController.UpdateIncident(incident, newIncident);
                if (updated)
                {
                    MessageBox.Show("You have successfully updated the incident.");
                    this.ClearBoxes();
                }
                else
                {
                    MessageBox.Show("The incident could not be updated at ths time");
                }
                 /
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }*/

        /// <summary>
        /// Updates the incident with new information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateIncidentButton_Click(object sender, EventArgs e)
        {
            Incidents newIncident = new Incidents();
            newIncident.IncidentID = incident.IncidentID;

            try
            {               
                string formattedText = txtDescription.Text + Environment.NewLine +
                    "<" + DateTime.Now.ToString("d") + "> " + txtToAdd.Text;
                if (formattedText.Length > 200)
                {
                    DialogResult dialogResult = MessageBox.Show("Total description can only be 200 characters. Truncate automatically?",
                        "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        formattedText = formattedText.Substring(0, 200);
                        newIncident.Description = formattedText;
                        this.PutIncidentData(newIncident);
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
                    else
                    {
                        newIncident.Description = formattedText;
                        this.PutIncidentData(newIncident);
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
                incident.TechID = (int)technicianComboBox.SelectedValue;


                if (txtToAdd.Text == "")
                {
                    txtToAdd.Text = "Technician was updated.";
                }
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private string FormattedText()
        {
            string formattedText = txtDescription.Text + Environment.NewLine +
                    "<" + DateTime.Now.ToString("d") + "> " + txtToAdd.Text;
            if (formattedText.Length > 200)
            {
                DialogResult dialogResult = MessageBox.Show("Total description can only be 200 characters. Truncate automatically?", 
                    "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    formattedText = formattedText.Substring(0, 200);
                }
            }
            return formattedText;
        }
        /*
        /// <summary>
        /// Sets the data in the form to an Incident object to be updated in the database
        /// </summary>
        /// <param name="incident"></param>
        private void PutIncidentData(Incidents newIncident)
        {
            try
            {
                
                newIncident.TechID = (int)technicianComboBox.SelectedValue;

                if (newIncident.TechID == incident.TechID)
                {
                    if (txtToAdd.Text == "")
                    {
                        MessageBox.Show("You must make a change in order to update the incident.");
                    }
                    else
                    {
                        newIncident.Description = this.FormattedText();
                    }
                }
                else
                {
                    if (txtToAdd.Text == "")
                    {
                        txtToAdd.Text = "Technician was updated.";
                    }
                    else
                    {
                        newIncident.Description = this.FormattedText();
                    }
                    this.PutIncidentData(newIncident);
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
        */
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
                updated = IncidentsController.CloseIncident(incident.IncidentID);
                if (updated)
                {
                    MessageBox.Show("You have successfully closed the incident.");
                    this.ClearBoxes();
                }
                else
                {
                    MessageBox.Show("The incident could not be closed at ths time");
                    this.ClearBoxes();
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

        /// <summary>
        /// Clears the textboxes and resets the combobox to refresh the page info.
        /// </summary>
        private void ClearBoxes()
        {
            var t = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>();
            foreach (TextBox item in t)
            {
                item.Text = "";
            }
            this.technicianComboBox.SelectedIndex = -1;
        }
    }
}

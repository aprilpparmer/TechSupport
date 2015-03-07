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
        private int technicianSelectedIndex;
        private bool putIncidentData;
        private Incidents newIncident;


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
                technicianSelectedIndex = technicianComboBox.SelectedIndex;

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

        /// <summary>
        /// Updates the incident in the database when the "Update" button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateIncidentButton_Click(object sender, EventArgs e)
        {
            putIncidentData = true;
            newIncident.IncidentID = incident.IncidentID;
            this.PutIncidentData(newIncident);
            try
            {
                if (putIncidentData)
                {
                    bool updated = IncidentsController.UpdateIncident(incident, newIncident);
                    if (updated)
                    {
                        MessageBox.Show("You have successfully updated the incident.");
                        ClearBoxes();
                    }
                    else
                    {
                        MessageBox.Show("The incident could not be updated at this time");
                        ClearBoxes();
                    }
                }
                else
                {
                   
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Saves the proper new incident data
        /// </summary>
        /// <param name="newIncident"></param>
        /// <returns></returns>
        private bool PutIncidentData(Incidents newIncident)
        {
            try
            {
                if (technicianComboBox.SelectedIndex != -1)
                {
                    newIncident.TechID = (int)technicianComboBox.SelectedValue;
                }
                else
                {
                    newIncident.TechID = incident.TechID;
                }
                if (technicianComboBox.SelectedIndex == technicianSelectedIndex)
                {
                    //check to see if text changed
                    if (txtToAdd.Text == "")
                    {
                        MessageBox.Show("You must make a change in order to update.");
                        putIncidentData = false;
                    }
                    else
                    {
                        this.FormatDescription(txtToAdd.Text);
                    }
                }
                else
                {
                    if (txtToAdd.Text == "")
                    {
                        this.FormatDescription("Technician changed");
                    }
                    else
                    {
                        this.FormatDescription(txtToAdd.Text);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }                
                return putIncidentData;
        }

        /// <summary>
        /// Formats the incident description properly
        /// </summary>
        /// <param name="newText"></param>
        private void FormatDescription(string newText)
        {
            string formattedDescription = incident.Description + Environment.NewLine +
                "<" + DateTime.Now.ToString("d") + "> " + newText;
            if (formattedDescription.Length > 200) 
            {
                DialogResult dialogResult = MessageBox.Show("Total description can only " +
                    "be 200 characters. Truncate automatically?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    newIncident.Description = formattedDescription.Substring(0, 200);
                }
                else
                {
                    putIncidentData = false;
                    newIncident.Description = incident.Description;
                    return;
                }
            }
            else
            {
                newIncident.Description = formattedDescription;
            }
        }
    }
}

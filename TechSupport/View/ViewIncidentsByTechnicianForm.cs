using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class ViewIncidentsByTechnicianForm : Form
    {
        private Technicians technician;
        private List<Technicians> techniciansList;
        private List<Incidents> incidentsList;

        public ViewIncidentsByTechnicianForm()
        {
            InitializeComponent();
        }

        private void ViewIncidentsByTechnicianForm_Load(object sender, EventArgs e)
        {
            this.GetTechniciansWithIncidents();
            this.GetTechnicianData();
        }

        private void GetTechniciansWithIncidents()
        {
            try
            {
                // Get the list of Technicians and bind the combo box to the list
                techniciansList = TechniciansController.GetTechniciansWithIncidents();
                technicianComboBox.DataSource = techniciansList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void GetTechnicianData()
        {
            try
            {
                int techID = (int)technicianComboBox.SelectedValue;
                technician = TechniciansController.GetTechnicianData(techID);
                techniciansBindingSource.Clear();
                techniciansBindingSource.Add(technician);                
                
                // Get the list of incidents for the technician
                incidentsList = IncidentsController.GetTechnicianIncidents(techID);
                incidentsDataGridView.DataSource = incidentsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void technicianComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetTechnicianData();
        }
    }
}

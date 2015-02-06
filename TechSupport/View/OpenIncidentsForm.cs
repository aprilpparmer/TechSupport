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
using TechSupport.DAL;
using TechSupport.Controller;

namespace TechSupport
{
    public partial class OpenIncidentsForm : Form
    {
        private IncidentsController inController;
        public OpenIncidentsForm()
        {
            InitializeComponent();
            inController = new IncidentsController();
        }

        //When form loads, all open incidents are displayed
        private void Form2_Load(object sender, EventArgs e)
        {
            listViewOpenIncidents.Items.Clear();
            List<Incidents> incidentsList;
            try
            {
                incidentsList = this.inController.DisplayOpenIncidents();
                if (incidentsList.Count > 0)
                {
                    Incidents incident;
                    for (int i = 0; i < incidentsList.Count; i++)
                    {
                        incident = incidentsList[i];
                        listViewOpenIncidents.Items.Add(incident.ProductCode);
                        listViewOpenIncidents.Items[i].SubItems.Add(incident.DateOpened.ToShortDateString());
                        listViewOpenIncidents.Items[i].SubItems.Add(incident.CustomerName);
                        listViewOpenIncidents.Items[i].SubItems.Add(incident.Technician);
                        listViewOpenIncidents.Items[i].SubItems.Add(incident.Title);
                    }   
                }
                else
                {
                    MessageBox.Show("There are currently no open incidents.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupport.View
{
    /// <summary>
    /// Creates a report for open incidents that have been assigned a technician
    /// </summary>
    public partial class TechnicianOpenIncidentsReport : Form
    {
        public TechnicianOpenIncidentsReport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the report information for open incidents that have been assigned technicians
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TechnicianOpenIncidentsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'technicianIncidents.TechnicianOpenIncidents' table. You can move, or remove it, as needed.
            this.technicianOpenIncidentsTableAdapter.Fill(this.technicianIncidents.TechnicianOpenIncidents);

            this.reportViewer1.RefreshReport();
        }
    }
}

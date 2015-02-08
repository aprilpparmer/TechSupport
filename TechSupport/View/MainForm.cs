using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;
using TechSupport.Controller;
using System.Data.SqlClient;

namespace TechSupport
{
    /// <summary>
    /// Displays the main (parent) form of the application. 
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OpenIncidentsForm f2;
        CreateIncidentForm cif;

        /// <summary>
        /// Displays the Open Incidents Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayOpenIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new OpenIncidentsForm();
                f2.MdiParent = this;
                f2.FormClosed += f2_FormClosed;
                f2.Show();
            }
            else
                f2.Activate();
        }

        /// <summary>
        /// Sets the Display Open Incidents Form to closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

        /// <summary>
        /// When selected, the application exits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Displays the Create Incident Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cif == null)
                {
                    cif = new CreateIncidentForm();
                    cif.MdiParent = this;
                    cif.FormClosed += cif_FormClosed;
                    cif.Show();
                }
                else
                    cif.Activate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        /// <summary>
        /// Sets the Create Incident Form to closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cif_FormClosed(object sender, FormClosedEventArgs e)
        {
            cif = null;
        }
    }
}

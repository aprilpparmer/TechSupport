﻿using System;
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
        UpdateIncidentForm uif;
        ViewIncidentsByTechnicianForm vibt;
        TechnicianOpenIncidentsReport toir;

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

        /// <summary>
        /// Displays the Update Incident Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (uif == null)
                {
                    uif = new UpdateIncidentForm();
                    uif.MdiParent = this;
                    uif.FormClosed += uif_FormClosed;
                    uif.Show();
                }
                else
                    uif.Activate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        void uif_FormClosed(object sender, FormClosedEventArgs e)
        {
            uif = null;
        }

        /// <summary>
        /// Displays the View Open Incidents By Technician Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewOpenIncidentByTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (vibt == null)
                {
                    vibt = new ViewIncidentsByTechnicianForm();
                    vibt.MdiParent = this;
                    vibt.FormClosed += vibt_FormClosed;
                    vibt.Show();
                }
                else
                    vibt.Activate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        /// <summary>
        /// Closes the view incidents by technician form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vibt_FormClosed(object sender, FormClosedEventArgs e)
        {
            vibt = null;
        }

        /// <summary>
        /// Displays the Report for Open Incidents by Technician
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayIncidentsByProductAndTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (toir == null)
                {
                    toir = new TechnicianOpenIncidentsReport();
                    toir.MdiParent = this;
                    toir.FormClosed += toir_FormClosed;
                    toir.Show();
                }
                else
                    toir.Activate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
        /// <summary>
        /// Closes the open incidents by technician report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void toir_FormClosed(object sender, FormClosedEventArgs e)
        {
            toir = null;
        }
    }
}

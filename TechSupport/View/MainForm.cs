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

namespace TechSupport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OpenIncidentsForm f2;
        CreateIncidentForm cif;

        //When form loads, it fills the pages and a menu is displayed
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

        void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createIncidentToolStripMenuItem_Click(object sender, EventArgs e)
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

        void cif_FormClosed(object sender, FormClosedEventArgs e)
        {
            cif = null;
        }
    }
}

namespace TechSupport.View
{
    partial class TechnicianOpenIncidentsReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.technicianIncidents = new TechSupport.TechnicianIncidents();
            this.technicianOpenIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technicianOpenIncidentsTableAdapter = new TechSupport.TechnicianIncidentsTableAdapters.TechnicianOpenIncidentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.technicianIncidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TechniciansOpenIncidents";
            reportDataSource1.Value = this.technicianOpenIncidentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TechSupport.TechniciansOpenIncidents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(531, 286);
            this.reportViewer1.TabIndex = 0;
            // 
            // technicianIncidents
            // 
            this.technicianIncidents.DataSetName = "TechnicianIncidents";
            this.technicianIncidents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicianOpenIncidentsBindingSource
            // 
            this.technicianOpenIncidentsBindingSource.DataMember = "TechnicianOpenIncidents";
            this.technicianOpenIncidentsBindingSource.DataSource = this.technicianIncidents;
            // 
            // technicianOpenIncidentsTableAdapter
            // 
            this.technicianOpenIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // TechnicianOpenIncidentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 286);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TechnicianOpenIncidentsReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Incidents - Report";
            this.Load += new System.EventHandler(this.TechnicianOpenIncidentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicianIncidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicianOpenIncidentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TechnicianIncidents technicianIncidents;
        private System.Windows.Forms.BindingSource technicianOpenIncidentsBindingSource;
        private TechnicianIncidentsTableAdapters.TechnicianOpenIncidentsTableAdapter technicianOpenIncidentsTableAdapter;
    }
}
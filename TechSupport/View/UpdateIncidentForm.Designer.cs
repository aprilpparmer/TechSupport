namespace TechSupport.View
{
    partial class UpdateIncidentForm
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
            this.incidentIDLabel = new System.Windows.Forms.Label();
            this.textToAddLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incidentIDLabel
            // 
            this.incidentIDLabel.AutoSize = true;
            this.incidentIDLabel.Location = new System.Drawing.Point(31, 26);
            this.incidentIDLabel.Name = "incidentIDLabel";
            this.incidentIDLabel.Size = new System.Drawing.Size(62, 13);
            this.incidentIDLabel.TabIndex = 0;
            this.incidentIDLabel.Text = "Incident ID:";
            // 
            // textToAddLabel
            // 
            this.textToAddLabel.AutoSize = true;
            this.textToAddLabel.Location = new System.Drawing.Point(31, 261);
            this.textToAddLabel.Name = "textToAddLabel";
            this.textToAddLabel.Size = new System.Drawing.Size(69, 13);
            this.textToAddLabel.TabIndex = 3;
            this.textToAddLabel.Text = "Text To Add:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(31, 231);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Location = new System.Drawing.Point(31, 202);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Size = new System.Drawing.Size(74, 13);
            this.dateOpenedLabel.TabIndex = 5;
            this.dateOpenedLabel.Text = "Date Opened:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(31, 164);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(31, 134);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(63, 13);
            this.technicianLabel.TabIndex = 7;
            this.technicianLabel.Text = "Technician:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(31, 100);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(47, 13);
            this.productLabel.TabIndex = 8;
            this.productLabel.Text = "Product:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(31, 63);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(54, 13);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer:";
            // 
            // UpdateIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 401);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateOpenedLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.textToAddLabel);
            this.Controls.Add(this.incidentIDLabel);
            this.Name = "UpdateIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidentIDLabel;
        private System.Windows.Forms.Label textToAddLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label customerLabel;
    }
}
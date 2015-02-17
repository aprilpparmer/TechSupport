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
            this.components = new System.ComponentModel.Container();
            this.incidentIDLabel = new System.Windows.Forms.Label();
            this.textToAddLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.txtIncidentID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDateOpened = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtToAdd = new System.Windows.Forms.TextBox();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet2 = new TechSupport.TechSupportDataSet2();
            this.getIncidentButton = new System.Windows.Forms.Button();
            this.updateIncidentButton = new System.Windows.Forms.Button();
            this.closeIncidentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.techniciansTableAdapter = new TechSupport.TechSupportDataSet2TableAdapters.TechniciansTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentIDLabel
            // 
            this.incidentIDLabel.AutoSize = true;
            this.incidentIDLabel.Location = new System.Drawing.Point(24, 31);
            this.incidentIDLabel.Name = "incidentIDLabel";
            this.incidentIDLabel.Padding = new System.Windows.Forms.Padding(5);
            this.incidentIDLabel.Size = new System.Drawing.Size(72, 23);
            this.incidentIDLabel.TabIndex = 0;
            this.incidentIDLabel.Text = "Incident ID:";
            // 
            // textToAddLabel
            // 
            this.textToAddLabel.AutoSize = true;
            this.textToAddLabel.Location = new System.Drawing.Point(24, 311);
            this.textToAddLabel.Name = "textToAddLabel";
            this.textToAddLabel.Size = new System.Drawing.Size(69, 13);
            this.textToAddLabel.TabIndex = 3;
            this.textToAddLabel.Text = "Text To Add:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(24, 188);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Padding = new System.Windows.Forms.Padding(5);
            this.descriptionLabel.Size = new System.Drawing.Size(73, 23);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description:";
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Location = new System.Drawing.Point(24, 162);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Padding = new System.Windows.Forms.Padding(5);
            this.dateOpenedLabel.Size = new System.Drawing.Size(84, 23);
            this.dateOpenedLabel.TabIndex = 5;
            this.dateOpenedLabel.Text = "Date Opened:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(24, 136);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.titleLabel.Size = new System.Drawing.Size(40, 23);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(24, 107);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Padding = new System.Windows.Forms.Padding(5);
            this.technicianLabel.Size = new System.Drawing.Size(73, 23);
            this.technicianLabel.TabIndex = 7;
            this.technicianLabel.Text = "Technician:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(24, 80);
            this.productLabel.Name = "productLabel";
            this.productLabel.Padding = new System.Windows.Forms.Padding(5);
            this.productLabel.Size = new System.Drawing.Size(57, 23);
            this.productLabel.TabIndex = 8;
            this.productLabel.Text = "Product:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(24, 54);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Padding = new System.Windows.Forms.Padding(5);
            this.customerLabel.Size = new System.Drawing.Size(64, 23);
            this.customerLabel.TabIndex = 9;
            this.customerLabel.Text = "Customer:";
            // 
            // txtIncidentID
            // 
            this.txtIncidentID.Location = new System.Drawing.Point(114, 31);
            this.txtIncidentID.Name = "txtIncidentID";
            this.txtIncidentID.Size = new System.Drawing.Size(100, 20);
            this.txtIncidentID.TabIndex = 1;
            this.txtIncidentID.Tag = "IncidentID";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(114, 188);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(268, 117);
            this.txtDescription.TabIndex = 11;
            // 
            // txtDateOpened
            // 
            this.txtDateOpened.Enabled = false;
            this.txtDateOpened.Location = new System.Drawing.Point(114, 162);
            this.txtDateOpened.Name = "txtDateOpened";
            this.txtDateOpened.ReadOnly = true;
            this.txtDateOpened.Size = new System.Drawing.Size(105, 20);
            this.txtDateOpened.TabIndex = 12;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(114, 136);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(268, 20);
            this.txtTitle.TabIndex = 13;
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(114, 83);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(268, 20);
            this.txtProduct.TabIndex = 14;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(114, 57);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(268, 20);
            this.txtCustomer.TabIndex = 15;
            // 
            // txtToAdd
            // 
            this.txtToAdd.Enabled = false;
            this.txtToAdd.Location = new System.Drawing.Point(114, 311);
            this.txtToAdd.Multiline = true;
            this.txtToAdd.Name = "txtToAdd";
            this.txtToAdd.ReadOnly = true;
            this.txtToAdd.Size = new System.Drawing.Size(268, 117);
            this.txtToAdd.TabIndex = 4;
            this.txtToAdd.Tag = "TextToAdd";
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.DataSource = this.techniciansBindingSource;
            this.technicianComboBox.DisplayMember = "Name";
            this.technicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianComboBox.Enabled = false;
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(114, 109);
            this.technicianComboBox.MaxDropDownItems = 50;
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(268, 21);
            this.technicianComboBox.TabIndex = 3;
            this.technicianComboBox.Tag = "Technician";
            this.technicianComboBox.ValueMember = "TechID";
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "Technicians";
            this.techniciansBindingSource.DataSource = this.techSupportDataSet2;
            // 
            // techSupportDataSet2
            // 
            this.techSupportDataSet2.DataSetName = "TechSupportDataSet2";
            this.techSupportDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getIncidentButton
            // 
            this.getIncidentButton.Location = new System.Drawing.Point(220, 28);
            this.getIncidentButton.Name = "getIncidentButton";
            this.getIncidentButton.Size = new System.Drawing.Size(75, 23);
            this.getIncidentButton.TabIndex = 2;
            this.getIncidentButton.Text = "Get Incident";
            this.getIncidentButton.UseVisualStyleBackColor = true;
            this.getIncidentButton.Click += new System.EventHandler(this.getIncidentButton_Click);
            // 
            // updateIncidentButton
            // 
            this.updateIncidentButton.Enabled = false;
            this.updateIncidentButton.Location = new System.Drawing.Point(124, 434);
            this.updateIncidentButton.Name = "updateIncidentButton";
            this.updateIncidentButton.Size = new System.Drawing.Size(75, 23);
            this.updateIncidentButton.TabIndex = 5;
            this.updateIncidentButton.Text = "Update";
            this.updateIncidentButton.UseVisualStyleBackColor = true;
            this.updateIncidentButton.Click += new System.EventHandler(this.updateIncidentButton_Click);
            // 
            // closeIncidentButton
            // 
            this.closeIncidentButton.Enabled = false;
            this.closeIncidentButton.Location = new System.Drawing.Point(205, 434);
            this.closeIncidentButton.Name = "closeIncidentButton";
            this.closeIncidentButton.Size = new System.Drawing.Size(90, 23);
            this.closeIncidentButton.TabIndex = 6;
            this.closeIncidentButton.Text = "Close Incident";
            this.closeIncidentButton.UseVisualStyleBackColor = true;
            this.closeIncidentButton.Click += new System.EventHandler(this.closeIncidentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(301, 434);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 477);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.closeIncidentButton);
            this.Controls.Add(this.updateIncidentButton);
            this.Controls.Add(this.getIncidentButton);
            this.Controls.Add(this.technicianComboBox);
            this.Controls.Add(this.txtToAdd);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDateOpened);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIncidentID);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateOpenedLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.textToAddLabel);
            this.Controls.Add(this.incidentIDLabel);
            this.Name = "UpdateIncidentForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Incident";
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet2)).EndInit();
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
        private System.Windows.Forms.TextBox txtIncidentID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDateOpened;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtToAdd;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.Button getIncidentButton;
        private System.Windows.Forms.Button updateIncidentButton;
        private System.Windows.Forms.Button closeIncidentButton;
        private System.Windows.Forms.Button cancelButton;
        private TechSupportDataSet2 techSupportDataSet2;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private TechSupportDataSet2TableAdapters.TechniciansTableAdapter techniciansTableAdapter;
    }
}
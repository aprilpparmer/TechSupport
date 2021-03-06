﻿namespace TechSupport.View
{
    partial class CreateIncidentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.createIncidentBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.CustomersTableAdapter();
            this.techSupportDataSet1 = new TechSupport.TechSupportDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TechSupport.TechSupportDataSet1TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(158, 116);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(223, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.Tag = "Title";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DataSource = this.customersBindingSource;
            this.customerComboBox.DisplayMember = "Name";
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(158, 33);
            this.customerComboBox.MaxDropDownItems = 100;
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(223, 21);
            this.customerComboBox.TabIndex = 1;
            this.customerComboBox.Tag = "CustomerName";
            this.customerComboBox.ValueMember = "CustomerID";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(158, 158);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 126);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.Tag = "Description";
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.productsBindingSource;
            this.productComboBox.DisplayMember = "Name";
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(158, 72);
            this.productComboBox.MaxDropDownItems = 100;
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(223, 21);
            this.productComboBox.TabIndex = 2;
            this.productComboBox.Tag = "ProductName";
            this.productComboBox.ValueMember = "ProductCode";
            // 
            // createIncidentBtn
            // 
            this.createIncidentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createIncidentBtn.Location = new System.Drawing.Point(158, 290);
            this.createIncidentBtn.Name = "createIncidentBtn";
            this.createIncidentBtn.Size = new System.Drawing.Size(126, 28);
            this.createIncidentBtn.TabIndex = 5;
            this.createIncidentBtn.Text = "Create Incident";
            this.createIncidentBtn.UseVisualStyleBackColor = true;
            this.createIncidentBtn.Click += new System.EventHandler(this.createIncidentBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(290, 290);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 28);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupportDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // techSupportDataSet1
            // 
            this.techSupportDataSet1.DataSetName = "TechSupportDataSet1";
            this.techSupportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createIncidentBtn);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Validator";
            this.Text = "Create Incident";
            this.Load += new System.EventHandler(this.CreateIncidentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button createIncidentBtn;
        private System.Windows.Forms.Button cancelBtn;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TechSupportDataSet1 techSupportDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}
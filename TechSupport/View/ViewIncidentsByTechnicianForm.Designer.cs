namespace TechSupport.View
{
    partial class ViewIncidentsByTechnicianForm
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
            System.Windows.Forms.Label technicianLabel;
            System.Windows.Forms.Label techEmailLabel;
            System.Windows.Forms.Label techPhoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIncidentsByTechnicianForm));
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.techniciansBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.techEmailTextBox = new System.Windows.Forms.TextBox();
            this.techPhoneTextBox = new System.Windows.Forms.TextBox();
            technicianLabel = new System.Windows.Forms.Label();
            techEmailLabel = new System.Windows.Forms.Label();
            techPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingNavigator)).BeginInit();
            this.techniciansBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // technicianLabel
            // 
            technicianLabel.AutoSize = true;
            technicianLabel.Location = new System.Drawing.Point(32, 38);
            technicianLabel.Name = "technicianLabel";
            technicianLabel.Size = new System.Drawing.Size(63, 13);
            technicianLabel.TabIndex = 1;
            technicianLabel.Text = "Technician:";
            // 
            // techEmailLabel
            // 
            techEmailLabel.AutoSize = true;
            techEmailLabel.Location = new System.Drawing.Point(32, 65);
            techEmailLabel.Name = "techEmailLabel";
            techEmailLabel.Size = new System.Drawing.Size(35, 13);
            techEmailLabel.TabIndex = 3;
            techEmailLabel.Text = "Email:";
            // 
            // techPhoneLabel
            // 
            techPhoneLabel.AutoSize = true;
            techPhoneLabel.Location = new System.Drawing.Point(32, 91);
            techPhoneLabel.Name = "techPhoneLabel";
            techPhoneLabel.Size = new System.Drawing.Size(41, 13);
            techPhoneLabel.TabIndex = 5;
            techPhoneLabel.Text = "Phone:";
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataSource = typeof(TechSupport.Model.Technicians);
            // 
            // techniciansBindingNavigator
            // 
            this.techniciansBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.techniciansBindingNavigator.BindingSource = this.techniciansBindingSource;
            this.techniciansBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.techniciansBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.techniciansBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.techniciansBindingNavigatorSaveItem});
            this.techniciansBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.techniciansBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.techniciansBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.techniciansBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.techniciansBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.techniciansBindingNavigator.Name = "techniciansBindingNavigator";
            this.techniciansBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.techniciansBindingNavigator.Size = new System.Drawing.Size(429, 25);
            this.techniciansBindingNavigator.TabIndex = 0;
            this.techniciansBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // techniciansBindingNavigatorSaveItem
            // 
            this.techniciansBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.techniciansBindingNavigatorSaveItem.Enabled = false;
            this.techniciansBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("techniciansBindingNavigatorSaveItem.Image")));
            this.techniciansBindingNavigatorSaveItem.Name = "techniciansBindingNavigatorSaveItem";
            this.techniciansBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.techniciansBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Technician", true));
            this.technicianComboBox.DataSource = this.techniciansBindingSource;
            this.technicianComboBox.DisplayMember = "Technician";
            this.technicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(107, 35);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(223, 21);
            this.technicianComboBox.TabIndex = 2;
            this.technicianComboBox.ValueMember = "TechID";
            this.technicianComboBox.SelectedIndexChanged += new System.EventHandler(this.technicianComboBox_SelectedIndexChanged);
            // 
            // techEmailTextBox
            // 
            this.techEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "TechEmail", true));
            this.techEmailTextBox.Location = new System.Drawing.Point(107, 62);
            this.techEmailTextBox.Name = "techEmailTextBox";
            this.techEmailTextBox.ReadOnly = true;
            this.techEmailTextBox.Size = new System.Drawing.Size(223, 20);
            this.techEmailTextBox.TabIndex = 4;
            // 
            // techPhoneTextBox
            // 
            this.techPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "TechPhone", true));
            this.techPhoneTextBox.Location = new System.Drawing.Point(107, 88);
            this.techPhoneTextBox.Name = "techPhoneTextBox";
            this.techPhoneTextBox.ReadOnly = true;
            this.techPhoneTextBox.Size = new System.Drawing.Size(108, 20);
            this.techPhoneTextBox.TabIndex = 6;
            // 
            // ViewIncidentsByTechnicianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 348);
            this.Controls.Add(techPhoneLabel);
            this.Controls.Add(this.techPhoneTextBox);
            this.Controls.Add(techEmailLabel);
            this.Controls.Add(this.techEmailTextBox);
            this.Controls.Add(technicianLabel);
            this.Controls.Add(this.technicianComboBox);
            this.Controls.Add(this.techniciansBindingNavigator);
            this.Name = "ViewIncidentsByTechnicianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Incidents By Technician";
            this.Load += new System.EventHandler(this.ViewIncidentsByTechnicianForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingNavigator)).EndInit();
            this.techniciansBindingNavigator.ResumeLayout(false);
            this.techniciansBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private System.Windows.Forms.BindingNavigator techniciansBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton techniciansBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.TextBox techEmailTextBox;
        private System.Windows.Forms.TextBox techPhoneTextBox;
    }
}
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
using TechSupport.Controller;
using System.Data.SqlClient;


namespace TechSupport.View
{
    /// <summary>
    /// Creates a form used to add a new incident to the database
    /// </summary>
    public partial class CreateIncidentForm : Form
    {
        private CustomersController custController;
        private ProductsController prodController;
        private Incidents incident;

        public CreateIncidentForm()
        {
            InitializeComponent();
            custController = new CustomersController();
            prodController = new ProductsController();
            this.loadCustomerNames();
            this.loadProductNames();
        }

        /// <summary>
        /// Loads the customer names into a combo box
        /// </summary>
        private void loadCustomerNames()
        {
            List<Customers> customerList;
            try
            {
                customerList = this.custController.GetAllCustomers();
                if (customerList.Count > 0)
                {
                    Customers customer;
                    for (int i = 0; i < customerList.Count; i++)
                    {
                        customer = customerList[i];
                        customerComboBox.Items.Add(customer.CustomerName);
                    }
                }
                else
                {
                    MessageBox.Show("There are no customer names to display.");
                    this.Close();
                }
                customerComboBox.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        /// <summary>
        /// Loads the product names into a combo box
        /// </summary>
        private void loadProductNames()
        {
            List<Products> productList;
            try
            {
                productList = this.prodController.GetAllProducts();
                if (productList.Count > 0)
                {
                    Products product;
                    for (int i = 0; i < productList.Count; i++)
                    {
                        product = productList[i];
                        productComboBox.Items.Add(product.ProductName);
                    }
                }
                else
                {
                    MessageBox.Show("There are no product names to display.");
                    this.Close();
                }
                productComboBox.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        /// <summary>
        /// When clicked, a new incident is created in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createIncidentBtn_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                    incident = new Incidents();
                    this.PutIncidentData(incident);
                    try
                    {
                        incident.IncidentID = IncidentsController.AddIncident(incident);
                        MessageBox.Show("You have successfully added a new incident.");
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
            }
        }

        /// <summary>
        /// Sets the data in the form to an Incident object to be added to the database
        /// </summary>
        /// <param name="incident"></param>
        private void PutIncidentData(Incidents incident)
        {
            incident.CustomerName = customerComboBox.Text;
            incident.ProductName = productComboBox.Text;
            incident.DateOpened = DateTime.Now;
            incident.Title = titleTextBox.Text;
            incident.Description = descriptionTextBox.Text;
        }

        /// <summary>
        /// Checks if any fields are left blank
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            if (Validator.IsPresent(customerComboBox) &&
                Validator.IsPresent(productComboBox) &&
                Validator.IsPresent(titleTextBox) &&
                Validator.IsPresent(descriptionTextBox))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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


namespace TechSupport.View
{
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void createIncidentBtn_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                incident = new Incidents();
                this.PutIncidentData(incident);
                try
                {
                    incident.IncidentID = IncidentsController.AddIncident(incident);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void PutIncidentData(Incidents incident)
        {
            incident.CustomerName = customerComboBox.SelectedValue.ToString();
            incident.ProductName = productComboBox.SelectedValue.ToString();
            incident.DateOpened = DateTime.Now;
            incident.Title = titleTextBox.Text;
            incident.Description = descriptionTextBox.Text;
        }

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
    }
}

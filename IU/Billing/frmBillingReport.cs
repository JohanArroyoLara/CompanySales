using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOM;
using BL;

namespace IU.Billing
{
    public partial class frmBillingReport : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();
        private List<ClientDOM> clients = null;

        public frmBillingReport()
        {
            InitializeComponent();
            ClientManager clientM = new ClientManager();
            clients = clientM.clientsList();
            int counter = 0;
            foreach (var item in clients)
            {

                cbClients.Items.Add(clients.ElementAt(counter).FirstName);
                counter = counter + 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BillingManager billingManager = new BillingManager();
            
          
                if (cbClients.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un cliente");
                }
                else
                {
                    int id = 0;
                    int counter = 0;
                    foreach (var item in clients)
                    {
                        if (cbClients.SelectedItem.ToString().Equals(clients.ElementAt(counter).FirstName))
                        {
                            id = clients.ElementAt(counter).Id;
                        }
                        counter = counter + 1;
                    }


                    int clientID = id;

          
                if (cbClients.SelectedIndex == -1)
                {
                    MessageBox.Show("Porfavor seleccione nn cliente");
                }
                else
                {
                    int id = 0;
                    int counter = 0;
                    foreach (var item in clients)
                    {
                        if (cbClients.SelectedItem.ToString().Equals(clients.ElementAt(counter).FirstName))
                        {
                            id = clients.ElementAt(counter).Id;
                        }
                        counter = counter + 1;
                    }


                    int clientID = id;

                    ClientManager clientManager = new ClientManager();
                    DateTime date1 = dtpSince.Value;
                    DateTime date2 = dtpTo.Value;

                    if (date1.Date <= date2.Date)
                    {

                        if (clientManager.getClient(clientID) != null)
                        {
                            List<BillingDOM> billings = billingManager.billingsReport(clientID,
                                                        date1, date2);
                            grdBilling.DataSource = billings;
                            txtTotal.Text = billingManager.total(billings).ToString();
                        }
                        else
                        {

                            MessageBox.Show("No se encontró al cliente");
                        }

                    }

                    else
                    {
                        MessageBox.Show("La segunda fecha no puede ser menor a la primera");
                    }

                }

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BillingManager billingManager = new BillingManager();
            BillingDOM billing = new BillingDOM();
            int idBilling;

            if (grdBilling.DataSource != null)
            {
                if (grdBilling.Rows.Count > 0)
                {
                    idBilling = (int) grdBilling.CurrentCell.Value;
                    billing = billingManager.getBilling(idBilling);
                    if (billing!=null)
                    {
                        MessageBox.Show(billingDetails(billing), "Detalles de la factura");
                    }
                    else
                    {
                        MessageBox.Show("Error al consultar factura");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Seleccione una factura");
                }
               
            }
            else
            {
                MessageBox.Show("Seleccione una factura");
            }
           
        }


        private string billingDetails(BillingDOM billing)
        {
            string details = "";
            OrderManager orderManager = new OrderManager();
            OrderDOM order = new OrderDOM();
            ProductManager productManager = new ProductManager();
            ProductDOM product = new ProductDOM();
            order = orderManager.getOrder(billing.OrderID);
            List<OrderDetailsDom> orderDetails = orderManager.getOrderDetails(order);

            details += "Fecha de facturación: " + billing.BillingDate.ToString() + "\n";
            details += "Número de orden: " + billing.OrderID.ToString() + "\n";
            details += "\nInfo del pedido: \n";

            foreach (OrderDetailsDom item in orderDetails)
            {
                details += "\n";
                product = productManager.getProduct(item.Product_ID1);
                details += "Producto: " + product.Name + "      " + "Precio unitario: " + product.SalesPrice;
            }

            details += "\n\nTOTAL: " + order.Total;

            return details;
        }


    }
}

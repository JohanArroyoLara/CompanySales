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
    public partial class frmAddBilling : Form
    {

        RegularExpressions regularExpressions = new RegularExpressions();
        private List<ClientDOM> clients = null;

        public frmAddBilling()
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

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            regularExpressions.onlyNumbers(e);
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

            ClientManager clientManager = new ClientManager();
            ProductManager productManager = new ProductManager();
            OrderManager orderManager = new OrderManager();
            List<OrderDOM> orders = new List<OrderDOM>();
            orderID.Items.Clear();
            orderDate.Items.Clear();
            orderPrice.Items.Clear();
            int total = 0;

            if (cbClients.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione un empleado a eliminar");
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


                if (clientManager.getClient(clientID) != null)
                {

                    orders = orderManager.clientOrders(clientID);

                    foreach (OrderDOM item in orders)
                    {
                        orderID.Items.Add(item.Id);
                        orderDate.Items.Add(item.Date.ToString("dd-MM-yyyy"));
                        orderPrice.Items.Add(item.Total);
                        total += int.Parse(item.Total.ToString());

                    }

                    txtSubTotal.Text = total.ToString();

                }
                else
                {
                    MessageBox.Show("No existe un cliente con esa cédula");
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BillingManager billingManager = new BillingManager();
            BillingDOM billing = new BillingDOM();
            OrderManager orderManager = new OrderManager();
            List<OrderDOM> orders = new List<OrderDOM>();

            if (cbClients.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione un empleado a eliminar");
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

                orders = orderManager.clientOrders(clientID);

                foreach (OrderDOM item in orders)
                {

                    billing = new BillingDOM(item.Client_ID, item.Id, item.Total);

                    if (billingManager.addBilling(billing))
                    {
                        MessageBox.Show("Facturación realizada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("ERROR realizando la facturación");
                    }

                }

            }

        }

        private void txtSubTotal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
           
            
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}

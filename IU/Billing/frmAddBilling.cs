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

        public frmAddBilling()
        {
            InitializeComponent();
            ClientManager orderM = new ClientManager();
            List<ClientDOM> orders = orderM.clientsList();
            int counter = 0;
            foreach (var item in orders)
            {

                comboBox1.Items.Add(orders.ElementAt(counter).Id + "  -  " + orders.ElementAt(counter).FirstName);
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


            if (regularExpressions.allTextBoxesFilled(txtClientID))
            {

                int clientID = int.Parse(txtClientID.Text);


                if (clientManager.getClient(clientID) != null)
                {

                    orders = orderManager.clientOrders(clientID);

                    foreach (OrderDOM item in orders)
                    {
                        orderID.Items.Add(item.Id);
                        orderDate.Items.Add(item.Date.ToString("dd-MM-yyyy"));

                    }

                    foreach (int item in orderID.Items)
                    {
                        total += item;
                    }

                    txtSubTotal.Text = total.ToString();

                }
                else
                {
                    MessageBox.Show("No existe un cliente con esa cédula");
                }


            }
            else
            {
                MessageBox.Show("Por favor, digite una cédula");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //BillingManager billingManager = new BillingManager();
            //BillingDOM billing = new BillingDOM();

            //for (int i = 0; i < orderID.Items.Count; i++)
            //{

            //    billing = new BillingDOM();

            //    if (billingManager.addBilling(billing))
            //    {
            //        MessageBox.Show("Facturación realizada con éxito");
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR realizando la facturación");
            //    }

            //}

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

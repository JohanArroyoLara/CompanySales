using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DOM;

namespace IU.Order
{
    public partial class frmDeleteOrder : Form
    {
        public frmDeleteOrder()
        {
            InitializeComponent();
            ClientManager client = new ClientManager();
            List<ClientDOM> clients = client.clientsList();
            foreach (var item in clients)
            {
                comboBoxCliente.Items.Add(item.FirstName);
            }
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           

            }

        private void button2_Click(object sender, EventArgs e)
        {

            OrderManager orderM = new OrderManager();
            List<OrderDetailsDom> orders = orderM.orderdetaiList();

            ProductManager product = new ProductManager();
            List<ProductDOM> products = product.productList();


            foreach (var item in orders)
            {
                if (item.Order_ID1==int.Parse(comboBox1.Text))
                    foreach (var items in products)
                    {
                        if (item.Product_ID1==items.Id)
                        {
                            textBox1.Text += items.Name;
                        }
                    }


                {
                   
                }
            }
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderManager order = new OrderManager();
            List<OrderDOM> orders = order.orderlist();

            int clientID = 0;

            ClientManager client = new ClientManager();
            List<ClientDOM> clients = client.clientsList();


            ProductManager product = new ProductManager();
            List<ProductDOM> products = product.productList();

            List<OrderDetailsDom> orderD = order.orderdetaiList();







            if (comboBoxCliente.SelectedIndex > -1)
            {

                foreach (var item in clients)
                {
                    if (comboBoxCliente.Text == item.FirstName)
                    {
                        clientID = item.Id;





                    }
                }




                foreach (var item in orders)
                {
                    if (item.Client_ID == clientID)
                    {

                        comboBox1.Items.Add(item.Id);


                    }





                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderManager order = new OrderManager();
            order.removeOrder(int.Parse(comboBox1.Text));

        }
    }
}

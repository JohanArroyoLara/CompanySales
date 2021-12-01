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
    public partial class frmEditOrder : Form
    {
        public frmEditOrder()
        {
            InitializeComponent();
            //OrderManager orderM = new OrderManager();
            //List<OrderDOM> orders = orderM.orderlist();
            //int counter = 0;
            //foreach (var item in orders)
            //{

            //    comboBox1.Items.Add(orders.ElementAt(counter).Id);
            //    counter = counter + 1;
            //}

            ClientManager orderM = new ClientManager();
            List<ClientDOM> orders = orderM.clientsList();
            int counter = 0;
            foreach (var item in orders)
            {

                comboBoxCliente.Items.Add(orders.ElementAt(counter).FirstName);
                counter = counter + 1;
            }



            ProductManager product = new ProductManager();
            List<ProductDOM> products = product.productList();
            foreach (var item in products)
            {
                comboBoxAddFurniture.Items.Add(item.Name);

       
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ClientManager orderM2 = new ClientManager();
            List<ClientDOM> orders2 = orderM2.clientsList();
            string name = comboBoxCliente.Text;
            int counter3 = 0;
            int diCliente = 0;
            foreach (var item in orders2)
            {
                if (orders2.ElementAt(counter3).FirstName==name)
                {
                    diCliente= orders2.ElementAt(counter3).Id;
                }
                
                counter3 = counter3 + 1;
            }



            int counter = 0;
            if (comboBoxCliente.SelectedIndex > -1)
            {
                OrderManager orderM = new OrderManager();
                ProductManager productM = new ProductManager();
                List<OrderDOM> orders = orderM.orderlist();
                List<OrderDetailsDom> orderD = new OrderManager().orderdetaiList();
                int counter23 = 0;

                

                foreach (var item in orders)
                {

                   
                        foreach (var items in orderD)
                        {

                        if (item.Id == items.Order_ID1)
                        {
                            String text = "" + productM.getProduct(items.Product_ID1).Name;
                            comboBoxOrderFurniture.Items.Add(text);

                            

                        }
                        counter23 = counter23 + 1;
                    }
                 
                    counter = counter + 1;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OrderManager orderM = new OrderManager();
            ProductManager productM = new ProductManager();
            
            List<OrderDetailsDom> orderDetails = orderM.orderdetaiList();
            List<ProductDOM> products = productM.productList();
            

            foreach (var item in products)
            {
                if (item.Name==comboBoxOrderFurniture.Text)
                {
                    foreach (var items in orderDetails)
                    {
                        if (item.Id==items.Product_ID1)
                        {
                            orderM.removeOrderDetails(items.ID1);
                        }
                    }


                   


                   
                }

            }


            
        }

        private void frmEditOrder_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxAddFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductManager productM = new ProductManager();
            OrderDetailsDom orderD = new OrderDetailsDom();
            OrderManager order = new OrderManager();
            ClientManager client = new ClientManager();


            List<ClientDOM> clients = client.clientsList();
            List<OrderDOM> orders = order.orderlist();
            List<ProductDOM> products = productM.productList();

            foreach (var item in products )
            {
                if (item.Name == comboBoxAddFurniture.Text)
                {
                    orderD.Product_ID1 = item.Id;
                }
            }

           
                foreach (var items in clients)
                {
                    if (items.FirstName==comboBoxCliente.Text)
                    {
                    foreach (var item in orders)
                    {
                        if (item.Client_ID==item.Client_ID)
                        {
                            orderD.Order_ID1 = item.Id;
                        }
                    }

                    }
                }

            orderD.Quantity1 = 1;
            orderD.Specifications1 = textBoxSpecifications.Text;

            order.addOrderDetail(orderD);

            textBoxSpecifications.Clear();
            




        }

        private void comboBoxOrderFurniture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace IU.Order
{
    public partial class frmAddOrder : Form
    {
        RegularExpressions regularExpressions = new RegularExpressions();

        OrderDetailsDom orderD = new OrderDetailsDom();
     

        List<int> listProducts = new List<int>();
        private int lastid = 0;


        public frmAddOrder()
        {
            InitializeComponent();
            ClientManager orderM = new ClientManager();
            List<ClientDOM> orders = orderM.clientsList();
            int counter = 0;
            foreach (var item in orders)
            {
                
                comboBox1.Items.Add(orders.ElementAt(counter).FirstName);
                counter = counter + 1;
            }

            ProductManager product = new ProductManager();
            List<ProductDOM> products = product.productList();
            int counter2 = 0;
            foreach (var item in products)
            {

                comboBox2.Items.Add(products.ElementAt(counter2).Name);
                counter2 = counter2 + 1;
            }

            OrderManager order = new OrderManager();
            List<OrderDOM> ordersl = order.orderlist();
            int lastid = 0;
            foreach (var item in ordersl)
            {
                if(item.Id > lastid)
                {
                    lastid = item.Id;
                }
                
            }
            this.lastid = lastid;
            textBoxID.Text = (lastid + 1).ToString();
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {

        }

        public static DateTime Now { get; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMuebles.Text += "\n"+comboBox2.Text+"\n"+"  ";
            ProductManager product = new ProductManager();
            List<ProductDOM> products = product.productList();
            int counter3 = 0;
          
            foreach (var item in products)
            {
                if (products.ElementAt(counter3).Name==comboBox2.Text)
                {
                  
                    listProducts.Add(products.ElementAt(counter3).Id);
                    
                }
                counter3 = counter3+1;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderManager ordertManager = new OrderManager();

            if (regularExpressions.allTextBoxesFilled(textBoxID,textBoxQuantity,txtMuebles))
            {

                ClientManager orderM = new ClientManager();
                List<ClientDOM> orders = orderM.clientsList();
                int counter = 0;
                int id=0;
                foreach (var item in orders)
                {
                    if (comboBox1.Text==orders.ElementAt(counter).FirstName)
                    {
                        id = orders.ElementAt(counter).Id;
                    }
                    
                    counter = counter + 1;
                }


                //DateTime date1 =  Convert.ToDateTime(textBoxDate.Text);
              
                OrderDOM order = new OrderDOM(int.Parse(textBoxID.Text),
                                                id,
                                                "Espera",
                                                DateTime.Now,
                                                DateTime.Now
                                                );


                int counter2 = 0;

                if (ordertManager.getOrder(order.Id) == null)
                {
                    ordertManager.addOrder(order);


                    OrderDetailsDom orderDetails = new OrderDetailsDom();
                    foreach (var item in listProducts)
                    {
                        orderDetails.ID1 =  counter2+ int.Parse(textBoxID.Text);
                        orderDetails.Product_ID1 = listProducts.ElementAt(counter2);
                        orderDetails.Order_ID1 = order.Id;
                        orderDetails.Quantity1 = int.Parse(textBoxQuantity.Text);
                        orderDetails.Specifications1 = "";
                        ordertManager.addOrderDetail(orderDetails);
                        counter2 = counter2 + 1;

                    }


                    MessageBox.Show("Orden agregado con éxito");
                }
                else
                {
                    MessageBox.Show("Ya existe un orden registrado con este id");
                }

            }
            else
            {
                MessageBox.Show("Por favor, rellene todas las casillas");
            }
        }
        
    }
}

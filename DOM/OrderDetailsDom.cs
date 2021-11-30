using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DOM
{
   public class OrderDetailsDom
    {

        private int ID;
        private int Product_ID;
        private int Order_ID;
        private int Quantity;
        private string Specifications;
      
       

        public OrderDetailsDom(int iD, int product_ID, int order_ID, int quantity, string specifications, OrderDOM order, ProductDOM product)
        {
            ID = iD;
            Product_ID = product_ID;
            Order_ID = order_ID;
            Quantity = quantity;
            Specifications = specifications;
           
        }

        public OrderDetailsDom()
        {
        }
        public int ID1 { get => ID; set => ID = value; }
        public int Product_ID1 { get => Product_ID; set => Product_ID = value; }
        public int Order_ID1 { get => Order_ID; set => Order_ID = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public string Specifications1 { get => Specifications; set => Specifications = value; }
    


    }
}

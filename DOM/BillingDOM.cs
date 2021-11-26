using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class BillingDOM
    {

        private int clientID;
        private int productID;
        private int quantity;
        private Decimal unitPrice;
        private Decimal subTotal;
        private DateTime billingDate;

        public BillingDOM()
        {
        }

        public BillingDOM(int clientID, int productID, int quantity, Decimal unitPrice, Decimal subTotal)
        {
            this.clientID = clientID;
            this.productID = productID;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.subTotal = subTotal;
        }

        public int ClientID { get => clientID; set => clientID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Decimal UnitPrice { get => unitPrice; set => unitPrice = value; }
        public Decimal SubTotal { get => subTotal; set => subTotal = value; }
        public DateTime BillingDate { get => billingDate; set => billingDate = value; }

    }

}

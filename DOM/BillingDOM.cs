using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOM
{
    public class BillingDOM
    {

        private int id;
        private int orderID;
        private int clientID;
        private Decimal subTotal;
        private DateTime billingDate;

        public BillingDOM()
        {
        }


        public BillingDOM(int id, int orderID, int clientID, Decimal subTotal)
        {
            this.id = id;
            this.orderID = orderID;
            this.clientID = clientID;
            this.subTotal = subTotal;
        }

        public BillingDOM(int id, int orderID, int clientID, Decimal subTotal, DateTime billingDate)
        {
            this.id = id;
            this.orderID = orderID;
            this.clientID = clientID;
            this.subTotal = subTotal;
            this.billingDate = billingDate;
        }

        public BillingDOM(int orderID, int clientID, Decimal subTotal)
        {
            this.orderID = orderID;
            this.clientID = clientID;
            this.subTotal = subTotal;
        }


        public int ID { get => id; set => id = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int OrderID { get => orderID; set => orderID = value; }
        public Decimal SubTotal { get => subTotal; set => subTotal = value; }
        public DateTime BillingDate { get => billingDate; set => billingDate = value; }

    }

}

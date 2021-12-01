using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;
using DA;

namespace BL
{
    public class BillingManager
    {

        BillingDAO billingDAO = new BillingDAO();

        public Boolean addBilling(BillingDOM billing)
        {
            return billingDAO.addBilling(billing);
        }

        public BillingDOM getBilling(int id)
        {
            return billingDAO.getBilling(id);
        }

            public Boolean removeBilling(int id)
        {
            return billingDAO.removeBilling(id);
        }

        public List<BillingDOM> billingsReport(int id, DateTime date1, DateTime date2)
        {
            return billingDAO.clientBillReport(id, date1, date2);
        }

        public List<BillingDOM> billingsList(int clientID)
        {
            return billingDAO.billingsList(clientID);
        }

        public double total(List<BillingDOM> billings)
        {
            double total = 0;

            foreach (BillingDOM bill in billings)
            {
                string totalS = bill.SubTotal.ToString();
                total += double.Parse(totalS);
            }

            return total;
        }

    }


}

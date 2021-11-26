using ContextDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOM;

namespace DA
{
    public class BillingDAO
    {
        
        ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

        public Boolean addBilling(BillingDOM billing)
        {

            Billing newBiling = new Billing();

            newBiling.ClientID = billing.ClientID;
            newBiling.ProductID = billing.ProductID;
            newBiling.Quantity = billing.Quantity;
            newBiling.UnitPrice = billing.UnitPrice;
            newBiling.SubTotal = billing.SubTotal;
            newBiling.BillingDate
                = DBContext.Database.SqlQuery<DateTime>("SELECT SYSDATETIME()").SingleOrDefault();

            DBContext.Billing.Add(newBiling);

            try
            {
                if (DBContext.SaveChanges() == 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }

        public List<BillingDOM> clientBillReport(int clientID, DateTime date1, DateTime date2)
        {

            List<Billing> list = new List<Billing>();
            List<BillingDOM> returnList = new List<BillingDOM>();
            list = DBContext.Billing.ToList();

            foreach (Billing b in list)
            {
                if (b.ClientID.Equals(clientID))
                {

                    if ((b.BillingDate.Date >= date1.Date) && (b.BillingDate.Date<=date2.Date))
                    {
                        BillingDOM billing = new BillingDOM(b.ClientID, b.ProductID,
                        b.Quantity, b.UnitPrice, b.SubTotal);
                        billing.BillingDate = b.BillingDate;
                        returnList.Add(billing);
                    }
                    
                }
            }

            return returnList;
        }

    }

}

using ContextDB;
using System;
using DOM;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DA
{
    class OrderDAO
    {
      
            ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

            public Boolean addOrder(OrderDOM order)
            {

                Order newOrder = new Order();

            newOrder.ID = order.Id;
            newOrder.Client_ID = order.Client_ID;
            newOrder.Date = order.Date;
            newOrder.State = order.State;
            newOrder.Term = order.Term;


                DBContext.Order.Add(newOrder);

                try
                {
                    if (DBContext.SaveChanges() == 1)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {

                    return false;
                }

                return false;
            }

            public OrderDOM getOrder(int id)
            {
                Order orderToFind = DBContext.Order.Find(id);
                OrderDOM order = new OrderDOM();

                if (orderToFind != null)
                {
                order.Id = orderToFind.ID;
                order.Client_ID = orderToFind.Client_ID;
                order.State = orderToFind.State;
                order.Date = orderToFind.Date;
                order.Term = orderToFind.Term;

                    return order;
                }
                else
                {
                    return null;
                }

            }

            public void updateEmployee(OrderDOM employee)
            {

                Order newOrder = new Order();

            newOrder.ID = employee.Id;
            newOrder.Client_ID = employee.Client_ID;
            newOrder.Date = employee.Date;
            newOrder.State = employee.State;
            newOrder.Term = employee.Term;

                DBContext.Order.Attach(newOrder);
                DBContext.Entry(newOrder).State = EntityState.Modified;
                DBContext.SaveChanges();

            }

            public Boolean removeOrder(int id)
            {
                try
                {
                   Order newOrder = DBContext.Order.Find(id);
                    DBContext.Entry(newOrder).State = EntityState.Deleted;
                    DBContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }

            public List<OrderDOM> ordersList()
            {

                List<Order> list = new List<Order>();
                List<OrderDOM> returnList = new List<OrderDOM>();
                list = DBContext.Order.ToList();

                foreach (Order e in list)
                {
                    returnList.Add(new OrderDOM(e.ID, e.Client_ID,e.State, e.Date, e.Term));
                }

                return returnList;
            }


        }
    
}

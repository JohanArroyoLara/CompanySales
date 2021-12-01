using ContextDB;
using DOM;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DA
{
   public class OrderDAO
    {

        ComapanySalesDBEntities DBContext = new ComapanySalesDBEntities();

        public Boolean addOrder(OrderDOM order)
        {

            Order newOrder = new Order();

            newOrder.ID = order.Id;
            newOrder.Client_ID = order.Client_ID;
            newOrder.Date = order.Date.Date;
            newOrder.State = order.State;
            newOrder.Term = order.Term.Date;
            newOrder.Total = order.Total;

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
                order.Total = (decimal)orderToFind.Total;

                return order;
            }
            else
            {
                return null;
            }

        }

        public void updateOrder(OrderDOM employee)
        {

            Order newOrder = new Order();

            newOrder.ID = employee.Id;
            newOrder.Client_ID = employee.Client_ID;
            newOrder.Date = employee.Date;
            newOrder.State = employee.State;
            newOrder.Term = employee.Term;
            newOrder.Total = employee.Total;

            DBContext.Order.Attach(newOrder);
            DBContext.Entry(newOrder).State = EntityState.Modified;
            DBContext.SaveChanges();

        }

        public void updateOrderState(OrderDOM orderID)
        {

            List<Order> list = new List<Order>();
            list = DBContext.Order.ToList();

            foreach (Order o in list)
            {
                if (o.ID.Equals(orderID.Id))
                {
                    o.State = "Entregada";
                    DBContext.Order.Attach(o);
                    DBContext.Entry(o).State = EntityState.Modified;
                    DBContext.SaveChanges();
                }
            }
                
            

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

            foreach (Order o in list)
            {
                returnList.Add(new OrderDOM(o.ID, o.Client_ID, o.State, o.Date, o.Term, (decimal)o.Total));
            }

            return returnList;
        }


        public List<OrderDOM> clientOrders(int idClient)
        {

            List<Order> list = new List<Order>();
            List<OrderDOM> returnList = new List<OrderDOM>();
            list = DBContext.Order.ToList();

            foreach (Order o in list)
            {
                if (!o.State.Equals("Entregada"))
                {
                    if (o.Client_ID.Equals(idClient))
                    {
                        returnList.Add(new OrderDOM(o.ID, o.Client_ID, o.State, o.Date, o.Term, (decimal)o.Total));
                    }
                }
            }

            return returnList;
        }

        public Boolean addOrderDetails(OrderDetailsDom orderD)
        {

            Order_Details newOrder = new Order_Details();
           
            newOrder.ID = orderD.ID1;
            newOrder.Product_ID = orderD.Product_ID1;
            newOrder.Order_ID = orderD.Order_ID1;
            newOrder.Quantity = orderD.Quantity1;
            newOrder.Specifications = orderD.Specifications1;


            DBContext.Order_Details.Add(newOrder);

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


        public List<OrderDetailsDom> getOrderDetails(OrderDOM order)
        {
            List<Order_Details> list = new List<Order_Details>();
            List<OrderDetailsDom> returnList = new List<OrderDetailsDom>();
            list = DBContext.Order_Details.ToList();

            foreach (Order_Details o in list)
            {
                if (o.Order_ID.Equals(order.Id))
                {
                        returnList.Add(new OrderDetailsDom(o.ID, o.Product_ID, o.Order_ID, o.Quantity, o.Specifications));
                }
            }

            return returnList;
        }



    }

}

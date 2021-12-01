using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using DOM;

namespace BL
{
    public class OrderManager
    {
        OrderDAO orderDao = new OrderDAO();


        public Boolean addOrder(OrderDOM order)
        {
            return orderDao.addOrder(order);
        }

        public OrderDOM getOrder(int id)
        {
            return orderDao.getOrder(id);
        }

        public Boolean removeOrder(int id)
        {
            return orderDao.removeOrder(id);
        }

        public void updateOrder(OrderDOM order)
        {
            orderDao.updateOrder(order);
        }

        public void updateOrderState(OrderDOM order)
        {
            orderDao.updateOrderState(order);
        }

        public void addOrderDetail(OrderDetailsDom order)
        {
            orderDao.addOrderDetails(order);
        }


        public List<OrderDOM> orderlist()
        {
            return orderDao.ordersList();
        }

        public List<OrderDOM> clientOrders(int idClient)
        {
            return orderDao.clientOrders(idClient);
        }

    }
}

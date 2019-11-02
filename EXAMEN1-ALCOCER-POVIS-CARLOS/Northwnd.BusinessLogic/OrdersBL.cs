using Northwnd.DataAccess.Internal;
using Northwnd.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.BusinessLogic
{
    public class OrdersBL
    {
        public List<OrdersFilterResponse> getOrders()
        {
            OrdersDA oOrdersDA = new OrdersDA();
            return oOrdersDA.getOrders();
        }
        public OrdersFilterResponse getOrdersID(int OrdersID)
        {
            OrdersDA oOrdersDA = new OrdersDA();
            return oOrdersDA.getOrdersID(OrdersID);
        }
        public List<OrdersDetailtFilterResponse> getOrdersDetailt(int OrdersID)
        {
            OrdersDA oOrdersDA = new OrdersDA();
            return oOrdersDA.getOrdersDetailt(OrdersID);
        }
    }
}

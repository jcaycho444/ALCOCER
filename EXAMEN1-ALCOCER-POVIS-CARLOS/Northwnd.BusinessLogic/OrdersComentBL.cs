using Northwnd.DataAccess.Internal;
using Northwnd.Entity.OrdersComent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.BusinessLogic
{
    public class OrdersComentBL
    {
        public int Guardar(OrdersComentRequest request)
        {
            OrdersComentDA oOrdersComentDA = new OrdersComentDA();
            return oOrdersComentDA.Guardar(request);
        }
    }
}

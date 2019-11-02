using Northwnd.DataAccess.Internal.EF;
using Northwnd.Entity.OrdersComent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.DataAccess.Internal
{
    public class OrdersComentDA
    {
        public int Guardar(OrdersComentRequest request)
        {

            Orders_comment oOrders_comment = new Orders_comment();
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {

                oOrders_comment.OrderID = request.OrderID;
                oOrders_comment.Confirmation_date = Tool.Utilies.FormatDate(request.Confirmation_date);
                oOrders_comment.Confirmation = request.Confirmation;
                oOrders_comment.comment = request.comment;
                db.Orders_comment.Add(oOrders_comment);
                db.SaveChanges();
                return oOrders_comment.Orders_commentID;
            }

            
        }
    }
}

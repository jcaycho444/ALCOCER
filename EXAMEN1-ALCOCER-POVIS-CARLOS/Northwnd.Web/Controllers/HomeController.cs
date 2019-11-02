using Northwnd.BusinessLogic;
using Northwnd.Entity.OrdersComent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwnd.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            OrdersBL oOrdersBL = new OrdersBL();
            ViewBag.Orders = oOrdersBL.getOrders();
            return View();
        }
        public ActionResult OrdersDetailt(string ID) {

            int OrdersID = Convert.ToInt32(ID);
            double Total = 0.0;
            OrdersBL oOrdersBL = new OrdersBL();
            ViewBag.Orders = oOrdersBL.getOrdersID(OrdersID);
            var OrdersDetailt = oOrdersBL.getOrdersDetailt(OrdersID);
            ViewBag.OrdersDetailt = OrdersDetailt;

            if (OrdersDetailt != null) {
                if (OrdersDetailt.Count > 0)
                {
                    foreach (var item in OrdersDetailt)
                    {
                        Total = Total + item.TotalPrice;
                    }
                }
            }

            ViewBag.TotalPrice = Total;
            return View();
        }

        public ActionResult GuardarComentario(OrdersComentRequest request) {
            OrdersComentBL oOrdersComentBL = new OrdersComentBL();
            int result = oOrdersComentBL.Guardar(request);
            return Json(new { result = result });
        }
    }
}
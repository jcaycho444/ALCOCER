using Northwnd.DataAccess.Internal.EF;
using Northwnd.Entity.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.DataAccess.Internal
{
    public class OrdersDA
    {
        public List<OrdersFilterResponse> getOrders()
        {
            List<OrdersFilterResponse> LstOrdersFilterResponse = new List<OrdersFilterResponse>();
            OrdersFilterResponse oOrdersFilterResponse = new OrdersFilterResponse();
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var Listado = (from t1 in db.Orders
                               join t2 in db.Customers on t1.CustomerID equals t2.CustomerID
                               select new {
                                   t1.OrderID,
                                   t1.OrderDate,
                                   t2.CompanyName,
                                   t2.Phone
                               }).ToList();

                if (Listado != null) {
                    if (Listado.Count > 0) {
                        foreach (var item in Listado)
                        {
                            oOrdersFilterResponse = new OrdersFilterResponse();
                            oOrdersFilterResponse.OrderID = item.OrderID;
                            oOrdersFilterResponse.OrderDate = (DateTime)item.OrderDate;
                            oOrdersFilterResponse.CompanyName = item.CompanyName;
                            oOrdersFilterResponse.Phone = item.Phone;
                            LstOrdersFilterResponse.Add(oOrdersFilterResponse);
                        }
                    }
                }
            }

            return LstOrdersFilterResponse;
        }

        public OrdersFilterResponse getOrdersID(int OrdersID)
        {
            
            OrdersFilterResponse oOrdersFilterResponse = new OrdersFilterResponse();
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var Entity = (from t1 in db.Orders
                               join t2 in db.Customers on t1.CustomerID equals t2.CustomerID
                               where t1.OrderID == OrdersID
                               select new
                               {
                                   t1.OrderID,
                                   t1.OrderDate,
                                   t2.CompanyName,
                                   t2.Phone
                               }).FirstOrDefault();

                if (Entity != null)
                {
                    if (Entity.OrderID > 0)
                    {
                       
                            oOrdersFilterResponse = new OrdersFilterResponse();
                            oOrdersFilterResponse.OrderID = Entity.OrderID;
                            oOrdersFilterResponse.OrderDate = (DateTime)Entity.OrderDate;
                            oOrdersFilterResponse.CompanyName = Entity.CompanyName;
                            oOrdersFilterResponse.Phone = Entity.Phone;
                       
                    }
                }
            }

            return oOrdersFilterResponse;
        }


        public List<OrdersDetailtFilterResponse> getOrdersDetailt(int OrdersID)
        {
            List<OrdersDetailtFilterResponse> LstOrdersDetailtFilterResponse = new List<OrdersDetailtFilterResponse>();
            OrdersDetailtFilterResponse oOrdersDetailtFilterResponse = new OrdersDetailtFilterResponse();
            using (NORTHWNDEntities db = new NORTHWNDEntities())
            {
                var Listado = (from t1 in db.Order_Details
                               join t2 in db.Products on t1.ProductID equals t2.ProductID
                               where t1.OrderID == OrdersID
                               select new
                               {
                                   t2.ProductID,
                                   t2.ProductName,
                                   t1.Quantity,
                                   t1.UnitPrice
                               }).ToList();

                if (Listado != null)
                {
                    if (Listado.Count > 0)
                    {
                        foreach (var item in Listado)
                        {
                            oOrdersDetailtFilterResponse = new OrdersDetailtFilterResponse();
                            oOrdersDetailtFilterResponse.ProductID = item.ProductID;
                            oOrdersDetailtFilterResponse.ProductName =  item.ProductName;
                            oOrdersDetailtFilterResponse.Quantity = item.Quantity;
                            oOrdersDetailtFilterResponse.UnitPrice = (double) item.UnitPrice;
                            oOrdersDetailtFilterResponse.TotalPrice = oOrdersDetailtFilterResponse.UnitPrice * oOrdersDetailtFilterResponse.Quantity;
                            LstOrdersDetailtFilterResponse.Add(oOrdersDetailtFilterResponse);
                        }
                    }
                }
            }

            return LstOrdersDetailtFilterResponse;
        }
    }
}

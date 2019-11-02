using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.Orders
{
    public class OrdersDetailtFilterResponse
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}

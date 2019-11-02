using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.OrdersComent
{
    public class OrdersComentRequest
    {
        public int OrderID { get; set; }
        public string Confirmation_date { get; set; }
        public int Confirmation { get; set; }
        public string comment { get; set; }
 

    }
}

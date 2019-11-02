﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.Orders
{
    public class OrdersFilterResponse
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Scaffolding.Models
{
    public partial class OrdersCompletedN
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public byte OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}

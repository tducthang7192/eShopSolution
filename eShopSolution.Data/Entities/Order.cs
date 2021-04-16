﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime OrderDate { get; set; }

        public Guid  UserId { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }
            
        public string ShipEmail { get; set; }

        public string ShipPhoneNumner { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


    }
}

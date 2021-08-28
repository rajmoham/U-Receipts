using System;
using System.Collections.Generic;

namespace Hackathon_KCLMS.Models
{
    public class CreateOrderModel
    {
        public DateTime DateOfPurchase { get; set; }
        public int StoreId { get; set; }
        public string CardNumber { get; set; }
        public List<int> ProductIds { get; set; }
        public List<int> Quantities { get; set; }
        public List<double> UnitPrices { get; set; }
        public double Amount { get; set; }
    }

    public class UpdateOrderAmountModel
    {
        public int OrderId { get; set; }
        public double Amount { get; set; }
    }
}
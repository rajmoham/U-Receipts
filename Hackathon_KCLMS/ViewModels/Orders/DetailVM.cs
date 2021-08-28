using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hackathon_KCLMS.Models;

namespace Hackathon_KCLMS.ViewModels.Orders
{
    public class DetailVM
    {
        public OrderHeader OrderHeader { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}

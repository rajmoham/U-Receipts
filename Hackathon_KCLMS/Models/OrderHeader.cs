using Hackathon_KCLMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.Models
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public ApplicationUser Customer { get; set; }

        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }

        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }

        public DateTime DateOfPurchase { get; set; }
    }
}

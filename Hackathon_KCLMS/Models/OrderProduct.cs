using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.Models
{
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }

        public int OrderHeaderId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}

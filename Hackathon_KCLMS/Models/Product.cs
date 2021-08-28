using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.Models
{
    public class Product
    {
        public int Id { get; set; }
        /*public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }*/

        public string Name { get; set; }
        public string Description { get; set; }
    }
}

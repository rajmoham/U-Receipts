using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Hackathon_KCLMS.Data;

namespace Hackathon_KCLMS.Models
{
    public class BankCardLink
    {
        [Key]
        public int Id { get; set; }
        public string CardNumberHashed { get; set; }
        public string Name { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}

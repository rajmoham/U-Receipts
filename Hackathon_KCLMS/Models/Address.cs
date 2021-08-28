using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Address line 1")]
        public string Line1 { get; set; }
        [Display(Name = "Address line 2")]
        public string Line2 { get; set; }
        [Display(Name = "Address line 3")]
        public string Line3 { get; set; }
        [Display(Name = "Postal code")]
        public string Postcode { get; set; }
    }
}

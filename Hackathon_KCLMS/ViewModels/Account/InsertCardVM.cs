using System;
using System.ComponentModel.DataAnnotations;
using Hackathon_KCLMS.Models;

namespace Hackathon_KCLMS.ViewModels.Account
{
    public class InsertCardVM
    {
        [MinLength(16, ErrorMessage = "Card number must be 16 digits long")]
        [MaxLength(16, ErrorMessage = "Card number must be 16 digits long")]
        [Display(Name = "Card number (16-digits)")]
        [Required]
        public string CardNumber { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

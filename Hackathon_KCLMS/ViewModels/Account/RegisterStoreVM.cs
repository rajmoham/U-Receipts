using Hackathon_KCLMS.Data;
using Hackathon_KCLMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.ViewModels.Account
{
    public class RegisterStoreVM
    {
        public string ReturnUrl { get; set; }

        public ApplicationUser User { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Store Store { get; set; }
    }
}

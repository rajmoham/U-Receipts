using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Hackathon_KCLMS.Data;
using Microsoft.AspNetCore.Identity;

namespace Hackathon_KCLMS.Helpers
{
    public static class IdentityService
    {
        public async static Task<ApplicationUser> GetUser(this ClaimsPrincipal User, UserManager<ApplicationUser> _userManager)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            ApplicationUser user = await _userManager.FindByEmailAsync(claimsIdentity.Name);
            return user;
        }
    }
}

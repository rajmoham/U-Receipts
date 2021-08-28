using System;
using System.Linq;
using Hackathon_KCLMS.Data;
using Hackathon_KCLMS.Data.Repositories;
using Hackathon_KCLMS.Helpers;
using Hackathon_KCLMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Hackathon_KCLMS.Areas.Identity.Data
{
    public class DbInitialiser
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly Repository<Product> _productRepository;

        public DbInitialiser(
            ApplicationDbContext db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            Repository<Product> productRepository
            )
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _productRepository = productRepository;
        }

        public void Initialise()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch
            {

            }

            if (!_roleManager.RoleExistsAsync(Constants.UserRoles.StoreManager).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(Constants.UserRoles.Customer)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(Constants.UserRoles.StoreManager)).GetAwaiter().GetResult();

                _productRepository.Add(new Product
                {
                    Name = "Product 1",
                    Description = "Description 1"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 2",
                    Description = "Description 2"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 3",
                    Description = "Description 3"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 4",
                    Description = "Description 4"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 5",
                    Description = "Description 5"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 6",
                    Description = "Description 6"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 7",
                    Description = "Description 7"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 8",
                    Description = "Description 8"
                });

                _productRepository.Add(new Product
                {
                    Name = "Product 9",
                    Description = "Description 9"
                });
                _productRepository.Save();
            }
        }
    }
}

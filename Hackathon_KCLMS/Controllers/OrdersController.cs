using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon_KCLMS.Data;
using Hackathon_KCLMS.Data.Repositories;
using Hackathon_KCLMS.Helpers;
using Hackathon_KCLMS.Models;
using Hackathon_KCLMS.ViewModels.Orders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hackathon_KCLMS.Controllers
{
    public class OrdersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Repository<Address> _addressRepository;
        private readonly Repository<Store> _storeRepository;
        private readonly Repository<BankCardLink> _bankCardLinkRepository;
        private readonly Repository<OrderHeader> _orderHeaderRepository;
        private readonly Repository<OrderProduct> _orderProductRepository;
        private readonly Repository<ApplicationUser> _appUserRepository;

        public OrdersController(
            UserManager<ApplicationUser> userManager,
            Repository<Address> addressRepository,
            Repository<Store> storeRepository,
            Repository<BankCardLink> bankCardLinkRepository,
            Repository<OrderHeader> orderHeaderRepository,
            Repository<ApplicationUser> appUserRepository,
            Repository<OrderProduct> orderProductRepository
            )
        {
            _userManager = userManager;
            _addressRepository = addressRepository;
            _storeRepository = storeRepository;
            _bankCardLinkRepository = bankCardLinkRepository;
            _orderHeaderRepository = orderHeaderRepository;
            _appUserRepository = appUserRepository;
            _orderProductRepository = orderProductRepository;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            ApplicationUser user = await User.GetUser(_userManager);

            List<OrderHeader> orderHeaders = _orderHeaderRepository.GetAll(o => o.CustomerId == user.Id, includeProperties: "Store,Customer").ToList();

            IndexVM viewModel = new IndexVM
            {
                OrderHeaders = orderHeaders
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Detail(int id)
        {
            OrderHeader header = _orderHeaderRepository.FirstOrDefault(o => o.Id == id, includeProperties: "Store,Customer");
            List<OrderProduct> products = _orderProductRepository.GetAll(p => p.OrderHeaderId == id, includeProperties: "Product").ToList();

            DetailVM viewModel = new DetailVM
            {
                OrderHeader = header,
                OrderProducts = products
            };

            return View(viewModel);
        }
    }
}

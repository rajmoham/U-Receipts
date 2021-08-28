using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon_KCLMS.Data;
using Hackathon_KCLMS.Data.Repositories;
using Hackathon_KCLMS.Helpers;
using Hackathon_KCLMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hackathon_KCLMS.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderManagementController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Repository<Address> _addressRepository;
        private readonly Repository<Store> _storeRepository;
        private readonly Repository<BankCardLink> _bankCardLinkRepository;
        private readonly Repository<OrderHeader> _orderHeaderRepository;
        private readonly Repository<OrderProduct> _orderProductRepository;
        private readonly Repository<ApplicationUser> _appUserRepository;

        public OrderManagementController(
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

        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderModel model)
        {
            BankCardLink link = _bankCardLinkRepository.FirstOrDefault(b => b.CardNumberHashed == model.CardNumber.GetHashString());

            if (link == null)
            {
                return BadRequest();
            }

            if (!(model.Quantities.Count == model.ProductIds.Count && model.ProductIds.Count == model.UnitPrices.Count))
                return BadRequest();

            string userId = link.UserId;

            OrderHeader header = new OrderHeader
            {
                StoreId = model.StoreId,
                CustomerId = userId,
                TotalAmount = model.Amount,
                DateOfPurchase = model.DateOfPurchase,
                TotalQuantity = model.Quantities.Sum()
            };
            _orderHeaderRepository.Add(header);
            _orderHeaderRepository.Save();

            for (int i = 0; i < model.ProductIds.Count; i++)
            {
                _orderProductRepository.Add(new OrderProduct
                {
                    ProductId = model.ProductIds[i],
                    OrderHeaderId = header.Id,
                    UnitPrice = model.UnitPrices[i],
                    Quantity = model.Quantities[i]
                });
            }
            _orderProductRepository.Save();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrder([FromBody] UpdateOrderAmountModel model)
        {
            OrderHeader header = _orderHeaderRepository.Find(model.OrderId);

            if (header == null)
                return BadRequest();

            header.TotalAmount = model.Amount;

            _orderHeaderRepository.Update(header);
            _orderHeaderRepository.Save();

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            _orderHeaderRepository.RemoveById(id);
            _orderHeaderRepository.Save();

            return Ok();
        }
    }
}
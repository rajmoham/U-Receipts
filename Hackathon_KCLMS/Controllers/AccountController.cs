using Hackathon_KCLMS.Data;
using Hackathon_KCLMS.Data.Repositories;
using Hackathon_KCLMS.Helpers;
using Hackathon_KCLMS.Models;
using Hackathon_KCLMS.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon_KCLMS.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Repository<Address> _addressRepository;
        private readonly Repository<Store> _storeRepository;
        private readonly Repository<BankCardLink> _bankCardLinkRepository;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            Repository<Address> addressRepository,
            Repository<Store> storeRepository,
            Repository<BankCardLink> bankCardLinkRepository
            )
        {
            _userManager = userManager;
            _addressRepository = addressRepository;
            _storeRepository = storeRepository;
            _bankCardLinkRepository = bankCardLinkRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterStore(string returnUrl)
        {
            return View(new RegisterStoreVM() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public IActionResult RegisterStore(RegisterStoreVM viewModel)
        {
            if (ModelState.IsValid)
            {
                if(viewModel.Password != viewModel.ConfirmPassword)
                {
                    return View();
                }

                Address storeAddress = viewModel.Store.Address;
                _addressRepository.Add(storeAddress);
                _addressRepository.Save();

                ApplicationUser userToRegister = viewModel.User;
                userToRegister.UserName = viewModel.User.Email;
                _userManager.CreateAsync(userToRegister, viewModel.Password);
                _userManager.AddToRoleAsync(userToRegister, Constants.UserRoles.StoreManager);

                Store store = new Store()
                {
                    AddressId = storeAddress.Id,
                    Name = viewModel.Store.Name
                };
                _storeRepository.Add(store);
                _storeRepository.Save();

                if(viewModel.ReturnUrl != null)
                {
                    return Redirect(viewModel.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public async Task<IActionResult> ManageCards()
        {
            ApplicationUser user = await User.GetUser(_userManager);

            ManageCardsVM viewModel = new ManageCardsVM()
            {
                Cards = _bankCardLinkRepository.GetAll(b => b.UserId == user.Id).ToList()
            };
            return View(viewModel);
        }

        public IActionResult InsertCard()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> InsertCard(InsertCardVM viewModel)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await User.GetUser(_userManager);
                BankCardLink cardLink = new BankCardLink
                {
                    CardNumberHashed = viewModel.CardNumber.GetHashString(),
                    Name = viewModel.Name,
                    UserId = user.Id
                };

                _bankCardLinkRepository.Add(cardLink);
                _bankCardLinkRepository.Save();

                return RedirectToAction(nameof(ManageCards));
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult DeleteCard(int id)
        {
            _bankCardLinkRepository.RemoveById(id);
            _bankCardLinkRepository.Save();
            return RedirectToAction(nameof(ManageCards));
        }
    }
}

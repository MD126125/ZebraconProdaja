using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZebraconProdaja.Models;
using ZebraconProdaja.ViewModels;

namespace ZebraconProdaja.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly IThermalPrintersRepository _thermalPrintersRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IThermalPrintersRepository thermalPrintersRepository, ShoppingCart shoppingCart)
        {
            _thermalPrintersRepository = thermalPrintersRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                TotalAmount = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int thermalPrintersId)
        {
            var selectedthermalPrinters = _thermalPrintersRepository.AllThermalPrinters.FirstOrDefault(p => p.Id == thermalPrintersId);

            if (selectedthermalPrinters != null)
            {
                _shoppingCart.AddToCart(selectedthermalPrinters, 1);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult RemoveFromShoppingCart(int thermalPrintersId)
        {
            var selectedthermalPrinters = _thermalPrintersRepository.AllThermalPrinters.FirstOrDefault(p => p.Id == thermalPrintersId);

            if (selectedthermalPrinters != null)
            {
                _shoppingCart.RemoveFromCart(selectedthermalPrinters);
            }
            return RedirectToAction("Index");
        }

    }
}

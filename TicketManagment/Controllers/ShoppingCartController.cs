
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

using TicketManagment.Models;

namespace TicketManagment.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = _shoppingCartService.GetShoppingCartInfo(userId);

            return View(model);
        }
        public IActionResult DeleteFromShoppingCart(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _shoppingCartService.DeleteProductFromShoppingCart(userId, id);

            return RedirectToAction("Index");
        }
        public IActionResult OrderNow(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _shoppingCartService.OrderNow(userId);

            return RedirectToAction("Index");

        }


        }
}

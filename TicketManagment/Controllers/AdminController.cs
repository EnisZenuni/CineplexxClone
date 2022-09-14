using Domain.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;
using System.Collections.Generic;

namespace TicketManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public readonly IOrderService _orderService;
     
        public AdminController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public List<Order> GetAllActiveOrders()
        {
            return this._orderService.GetAllOrders();
        }


    }
}

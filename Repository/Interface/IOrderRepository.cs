using Domain.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IOrderRepository<T> where T : BaseEntity
    {
        List<Order> GetAllOrders();
        Order GetOrderDetails(BaseEntity model);
    }
}

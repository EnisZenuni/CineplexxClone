using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDTO GetShoppingCartInfo(string userId);
        bool DeleteProductFromShoppingCart(string userId, int productId);
        bool OrderNow(string userId);
    }
}

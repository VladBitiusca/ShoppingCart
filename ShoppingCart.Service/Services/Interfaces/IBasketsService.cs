using ShoppingCart.Service.Models;

namespace ShoppingCart.Service.Interfaces
{
    public interface IBasketsService
    {
        void CreateBasket(BasketDto basket);
    }
}

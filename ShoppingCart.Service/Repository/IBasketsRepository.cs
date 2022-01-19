using ShoppingCart.Service.Models;

namespace ShoppingCart.Service.Repository
{
    public interface IBasketsRepository
    {
        void Create(BasketDto basket);
    }
}

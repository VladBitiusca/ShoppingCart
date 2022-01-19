using ShoppingCart.Service.Interfaces;
using ShoppingCart.Service.Models;
using ShoppingCart.Service.Repository;

namespace ShoppingCart.Service.Services
{
    public class BasketsService : IBasketsService
    {
        private readonly IBasketsRepository _basketsRepository;

        public BasketsService(IBasketsRepository basketsRepository)
        {
            _basketsRepository = basketsRepository;
        }

        public void CreateBasket(BasketDto basket)
        {
            _basketsRepository.Create(basket);
        }
    }
}
